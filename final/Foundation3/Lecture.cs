public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
   
    public Lecture(string title, string description, string date, string time, string address) : base(title, description, date, time, address)
    {

    }
}