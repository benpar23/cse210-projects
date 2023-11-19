public class Scripture
{
    private Reference _reference;

    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        
        string[] textSplit = text.Split(" ");

        foreach (string wordText in textSplit)
        {
            Word word = new Word(wordText);
            word.Show();
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        List<Word> hiddenWords = new List<Word>();

        List<bool> hiddens = new List<bool>();

        foreach (Word word in _words)
        {
            bool hidden = word.isHidden();

            if (hidden == true)
            {
                hiddens.Add(hidden);
            }
        }

        if (hiddens.Count < (_words.Count - numberToHide))
        {
            while (hiddenWords.Count() < numberToHide)
            {
                int index = random.Next(_words.Count);
                
                Word wordToHide = _words[index];

                if (wordToHide.isHidden() == false)
                {
                    wordToHide.Hide();
                    hiddenWords.Add(wordToHide);
                }
            }
        }
        else
        {
            numberToHide = _words.Count - hiddens.Count;

            while (numberToHide != 0)
            {
                int index = random.Next(_words.Count);
                
                Word wordToHide = _words[index];

                if (wordToHide.isHidden() == false)
                {
                    wordToHide.Hide();
                    numberToHide -= 1;
                }
            }
        }
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