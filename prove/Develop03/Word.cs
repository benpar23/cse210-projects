public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        if (_isHidden == true)
        {
            _text = "____";
        }

        GetDisplayText();
    }

    public void Show()
    {
        if (_isHidden == false)
        {
            GetDisplayText();
        }
    }

    public bool isHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetDisplayText()
    {
        return _text;
    }
}