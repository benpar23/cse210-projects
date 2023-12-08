public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
   
    public Lecture(string title, string description, string date, string time) : base(title, description, date, time)
    {

    }

    public override string GetFullDetails()
    {
        throw new NotImplementedException();
    }
}