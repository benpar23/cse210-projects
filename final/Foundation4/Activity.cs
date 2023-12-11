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
        string paceString = String.Format("{0:0.0#}", pace);
        double speed = GetSpeed();
        string speedString = String.Format("{0:0.0#}", speed);
        double distance = GetDistance();
        string distanceString = String.Format("{0:0.0#}", distance);
        string type = GetType().Name;

        return $"{_date} {type} ({_length} min)- Distance {distanceString} km, Speed {speedString} km/h, Pace: {paceString} min per km";
    }
}