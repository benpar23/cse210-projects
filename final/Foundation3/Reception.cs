public class Reception : Event
{
    private string _rsvp;
    
    public Reception(string title, string description, string date, string time) : base(title, description, date, time)
    {
        
    }

    public override string GetFullDetails()
    {
        throw new NotImplementedException();
    }
}