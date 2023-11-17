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
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
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
        if (_isHidden == true)
        {
            string underscores = new string('_',_text.Length);
            
            return underscores;
        }
        else
        {
            return _text;
        }
    }
}