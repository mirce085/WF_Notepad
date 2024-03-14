using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Notepad
{


    public partial class MainView : Form, IMainView
    {
        string IMainView.DText { get => richTextBox1.Text; set => richTextBox1.Text = value; }
        public string SelectedText { get => richTextBox1.SelectedText; set => richTextBox1.SelectedText = value; }
        public string FormText { get => Text; set => Text = value; }
        public string LineLabel { get => lineStatusLabel.Text; set => lineStatusLabel.Text = value; }
        public string ColumnLabel { get => columnStatusLabel.Text; set => columnStatusLabel.Text = value; }
        public int SelectionStart { get => richTextBox1.SelectionStart; set => richTextBox1.SelectionStart = value; }
        public string CapsLockLabelText { set => capsLockLabel.Text = value; }
        public string ReplaceFromText { get => replaceFromTextBox.Text; set => replaceFromTextBox.Text = value; }
        public string ReplaceToText { get => replaceToTextBox.Text; set => replaceToTextBox.Text = value; }
        public string LanguageLabelText { set => languageStatusLabel.Text = value; }
        public string LinesLabel { get => linesLabel.Text; set => linesLabel.Text = value; }
        public Color ForeCol { set => richTextBox1.SelectionColor = value; }
        public Font NewFont { set => richTextBox1.SelectionFont = value; }

        public MainView()
        {
            InitializeComponent();
        }

        public event Action OnExitClick;
        public event Action OnSaveClick;
        public event Action OnSaveAsClick;
        public event Action OnOpenClick;
        public event Action OnTextChange;
        public event Action OnCutClicked;
        public event Action OnCopyClicked;
        public event Action OnPasteClicked;
        public event Action OnSelectionChange;
        public event Action OnReplaceClicked;
        public event Action OnCapsLockClicked;
        public event Action OnGoToClicked;
        public event Action OnLanguageChange;
        public event Action OnColorClicked;
        public event Action OnFontClicked;

        private void MainView_Load(object sender, EventArgs e)
        {
            
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            OnExitClick?.Invoke();
        }

        private void saveMenu_Click(object sender, EventArgs e)
        {
            OnSaveClick?.Invoke();
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            OnOpenClick?.Invoke();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            OnTextChange?.Invoke();
            
        }

        private void saveAsMenu_Click(object sender, EventArgs e)
        {
            OnSaveAsClick?.Invoke();
        }

        private void cutMenu_Click(object sender, EventArgs e)
        {
            OnCutClicked?.Invoke();
        }

        private void copyMenu_Click(object sender, EventArgs e)
        {
            OnCopyClicked?.Invoke();
        }

        private void pasteMenu_Click(object sender, EventArgs e)
        {
            OnPasteClicked?.Invoke();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            OnSelectionChange?.Invoke();
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            OnReplaceClicked?.Invoke();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            OnCapsLockClicked?.Invoke();
            OnLanguageChange?.Invoke();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            OnGoToClicked?.Invoke();
        }

        private void colorMenu_Click(object sender, EventArgs e)
        {
            OnColorClicked?.Invoke();
        }

        private void fontMenu_Click(object sender, EventArgs e)
        {
            OnFontClicked?.Invoke();
        }
    }
}
