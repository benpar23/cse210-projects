public class Reception : Event
{
    private string _rsvp;
    
    public Reception(string title, string description, string date, string time, string rsvp) : base(title, description, date, time)
    {
        _rsvp = rsvp;
    }

    public override string GetFullDetails()
    {
        string standard = GetStandardDetails();

        string fullDetails = $"{standard}\r\n{_rsvp}";

        return fullDetails;
    }
}