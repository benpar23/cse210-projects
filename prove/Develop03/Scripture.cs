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
        return $"{_reference.GetDisplayText()} {_words}";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}