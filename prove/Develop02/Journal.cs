using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public string _name;

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        Console.WriteLine($"{_name}'s Journal");

        foreach (Entry entry in _entries) 
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            sw.WriteLine($"{_name}'s Journal");
            
            foreach (Entry entry in _entries)
            {
                sw.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);

        string[] name = lines[0].Split("'");

        _name = name[0];

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split("~");

            Entry newEntry = new Entry
            {
                _date = parts[0],
                _promptText = parts[1],
                _entryText = parts[2]
            };

            _entries.Add(newEntry);
        }
    }
}