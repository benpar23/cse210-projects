public class Scripture
{
    private Reference _reference;

    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        
        string[] firstSplit = text.Split("|");

        string[] finalSplit = firstSplit[1].Split(" ");

        foreach (string wordText in finalSplit)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        string text = string.Empty;

        foreach (Word word in _words)
        {
            text += $"{word.GetDisplayText()} ";
        }
        
        return $"{_reference.GetDisplayText()} {text}";
    }

    public bool IsCompletelyHidden()
    {
        List<bool> hiddens = new List<bool>();

        foreach (Word word in _words)
        {
            bool hidden = word.isHidden();
            hiddens.Add(hidden);
        }

        if (hiddens.Contains(false))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}