using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry _entry in _entries) 
        {
            _entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            foreach (Entry _entry in _entries)
            {
                sw.WriteLine($"Date: {_entry._date} - Prompt: {_entry._promptText}\r\n{_entry._entryText}\r\n");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        StreamReader sr = new StreamReader(file);
    }
}