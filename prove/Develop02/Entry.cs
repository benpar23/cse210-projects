public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _fullText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\r\n{_entryText}\r\n");
    }
}