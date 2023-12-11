public class OutdoorGathering : Event
{
    private string _weather;
    
    public OutdoorGathering(string title, string description, string date, string time, string weather) : base(title, description, date, time)
    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {
        string standard = GetStandardDetails();

        string fullDetails = $"{standard}\r\nWeather: {_weather}";

        return fullDetails;
    }
}