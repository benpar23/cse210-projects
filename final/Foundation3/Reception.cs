public class Reception : Event
{
    private string _rsvp;
    
    public Reception(string title, string description, string date, string time, string address) : base(title, description, date, time, address)
    {
        
    }
}