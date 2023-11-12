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
                sw.WriteLine($"{_entry._date}~{_entry._promptText}~{_entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        // StreamReader sr = new StreamReader(file);
        string[] _lines = File.ReadAllLines(file);


        foreach (string _line in _lines)
        {
            string[] parts = _line.Split("~");

            Entry newEntry = new Entry();

            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts [2];

            _entries.Add(newEntry);
        }
    }
}