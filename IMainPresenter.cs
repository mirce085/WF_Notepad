namespace WF_Notepad
{
    interface IMainPresenter
    {
        void ExitProgram();
        void SaveProgram();
        void SaveAsProgram();
        void OpenFile();
        void TextChanged();
        void CutText();
        void CopyText();
        void PasteText();
        void CursorPositionChanged();
        void Replace();
        void CapsLock();
        void Language();
        void LinesCount();
        void ColorChange();
        void FontChange();
    }
}
