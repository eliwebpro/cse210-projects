public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        // words visible in the begning
        _isHidden = false;
    }
// words hidden
    public void Hide()
    {
        _isHidden = true;
    }
// words visible back on
    public void Show()
    {
        _isHidden = false;
    }
// check the words hidden
    public bool IsHidden()
    {
        return _isHidden;
    }
// print the currently status hidden or not
    public string GetDisplayText()
    {
        return _isHidden ? "______" : _text;
    }
}
