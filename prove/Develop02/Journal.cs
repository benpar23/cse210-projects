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

    }
    public void LoadFromFile(string file)
    {

    }
}