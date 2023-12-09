using System.IO.Pipes;

public abstract class Activity
{
    private string _date;
    private double _length;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetPace();

    public abstract double GetSpeed();

    public abstract double GetDistance();

    public double GetLength()
    {
        return _length;
    }

    public string GetSummary()
    {
        double pace = GetPace();
        double speed = GetSpeed();
        double distance = GetDistance();
        string type = GetType().Name;

        return $"{_date} {type} ({_length} min)- Distance {distance} km, Speed {speed} km/h, Pace: {pace} min per km";
    }
}