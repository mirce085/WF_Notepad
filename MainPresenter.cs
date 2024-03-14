using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Notepad
{

    class MainPresenter : IMainPresenter
    {
        private IMainView _view;

        private string _filePath = string.Empty;

        private bool _isSaved = false;

        private string _savedText = string.Empty;

        public MainPresenter(IMainView view)
        {
            _view = view;
            _view.OnExitClick += ExitProgram;
            _view.OnSaveClick += SaveProgram;
            _view.OnOpenClick += OpenFile;
            _view.OnTextChange += TextChanged;
            _view.OnTextChange += LinesCount;
            _view.OnSaveAsClick += SaveAsProgram;
            _view.OnCutClicked += CutText;
            _view.OnPasteClicked += PasteText;
            _view.OnSelectionChange += CursorPositionChanged;
            _view.OnReplaceClicked += Replace;
            _view.OnCapsLockClicked += CapsLock;
            _view.OnLanguageChange += Language;
            _view.OnColorClicked += ColorChange;
            _view.OnFontClicked += FontChange;
            CursorPositionChanged();
            CapsLock();
            Language();
            LinesCount();
        }

        public void CapsLock()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                _view.CapsLockLabelText = "Caps Lock key is on";
                return;
            }
            _view.CapsLockLabelText = "Caps Lock key is off";
        }

        public void ColorChange()
        {
            ColorDialog colorDialog = new ColorDialog();
            
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                _view.ForeCol = colorDialog.Color;
            }
        }

        public void CopyText()
        {
            _savedText = _view.SelectedText;
        }

        public void CursorPositionChanged()
        {
            int lineCount = 1;
            int columnCount = 1;
            for (int i = 0; i < _view.SelectionStart; ++i)
            {
                if (_view.DText[i] == '\n')
                {
                    lineCount++;
                    columnCount = 0;
                }
                columnCount++;
            }
            _view.LineLabel = lineCount.ToString();
            _view.ColumnLabel = columnCount.ToString();
        }

        public void CutText()
        {
            _savedText = _view.SelectedText;
            _view.SelectedText = string.Empty;
        }

        public void ExitProgram()
        {
            if (!_isSaved)
            {
                var result = MessageBox.Show("Do you want to save all changes?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SaveProgram();
                }
            }
            Application.Exit();
        }

        public void FontChange()
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                _view.NewFont = fontDialog.Font;
            }
        }

        public void Language()
        {
            _view.LanguageLabelText = InputLanguage.CurrentInputLanguage.LayoutName;
        }

        public void LinesCount()
        {
            int linesCount = 1;
            foreach(var ch in _view.DText)
            {
                if(ch == '\n')
                {
                    linesCount++;
                }
            }
            _view.LinesLabel = linesCount.ToString();
        }

        public void OpenFile()
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(fileDialog.FileName))
                    {
                        _view.DText = reader.ReadToEnd();
                        var arr = fileDialog.FileName.Split('\\');
                        _view.FormText = arr[arr.Length - 1];
                    }
                    _filePath = fileDialog.FileName;
                }

            }
        }

        public void PasteText()
        {
            _view.DText += _savedText;
        }

        public void Replace()
        {
            if (_view.ReplaceFromText != string.Empty && _view.ReplaceToText != string.Empty)
            {
                _view.DText = _view.DText.Replace(_view.ReplaceFromText, _view.ReplaceToText);
                _view.ReplaceFromText = string.Empty;
                _view.ReplaceToText = string.Empty;
            }
        }

        public void SaveAsProgram()
        {
            using (SaveFileDialog fileDialog = new SaveFileDialog())
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(fileDialog.FileName, _view.DText);
                    _isSaved = true;
                }
            }
        }

        public void SaveProgram()
        {
            if (_filePath != string.Empty)
            {
                File.WriteAllText(_filePath, _view.DText);
                _isSaved = true;
                return;
            }
            MessageBox.Show("There is no file path!", "Path");
        }

        public void TextChanged()
        {
            _isSaved = false;
        }
    }
}
