public class OutdoorGathering : Event
{
    private string _weather;
    
    public OutdoorGathering(string title, string description, string date, string time) : base(title, description, date, time)
    {
        
    }

    public override string GetFullDetails()
    {
        throw new NotImplementedException();
    }
}