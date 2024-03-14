using System;
using System.Drawing;

namespace WF_Notepad
{
    interface IMainView
    {
        string DText { get; set; }
        string SelectedText { get; set; }
        string FormText { get; set; }
        string LineLabel { get; set; }
        string LinesLabel { get; set; }
        string ColumnLabel { get; set; }
        int SelectionStart { get; set; }
        string ReplaceFromText { get; set; }
        string ReplaceToText { get; set; }
        string CapsLockLabelText { set; }
        string LanguageLabelText { set; }
        Color ForeCol { set; }
        Font NewFont { set; }

        event Action OnExitClick;
        event Action OnSaveClick;
        event Action OnSaveAsClick;
        event Action OnOpenClick;
        event Action OnTextChange;
        event Action OnCutClicked;
        event Action OnCopyClicked;
        event Action OnPasteClicked;
        event Action OnSelectionChange;
        event Action OnReplaceClicked;
        event Action OnCapsLockClicked;
        event Action OnLanguageChange;
        event Action OnColorClicked;
        event Action OnFontClicked;
    }
}
