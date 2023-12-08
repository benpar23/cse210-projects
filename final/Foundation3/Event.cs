using System.Reflection;

public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
    }

    public string GetStandardDetails()
    {
        string addressString = _address.GetAddressString();
        
        return $"EVENT NAME: {_title}\r\nDescription: {_description}\r\nDate: {_date}\r\nTime: {_time}\r\n{addressString}";
    }

    public abstract string GetFullDetails();

    public string GetShortDescription()
    {
        string className = GetType().Name;

        if (className == "OutdoorGathering")
        {
            className = "Outdoor Gathering";
        }
        
        return $"Event Type: {className}\r\nTitle: {_title}\r\nDate: {_date}";
    }
}