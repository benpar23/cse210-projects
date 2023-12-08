public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
   
    public Lecture(string title, string description, string date, string time, string speaker, int capacity) : base(title, description, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        string standard = GetStandardDetails();

        string fullDetails = $"{standard}\r\nGuest Speaker: {_speaker}\r\nVenue Capacity: {_capacity}";

        return fullDetails;
    }
}