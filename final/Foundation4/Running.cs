public class Running : Activity
{
    private double _distance;

    public Running(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        double length = GetLength();

        double pace = length / _distance;

        return pace;
    }

    public override double GetSpeed()
    {
        double length = GetLength();
        double speed = _distance / length * 60;

        return speed;
    }
}