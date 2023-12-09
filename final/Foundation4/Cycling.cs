public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double length = GetLength();
        double distance = _speed / 60 * length;

        return distance;
    }

    public override double GetPace()
    {
        double length = GetLength();
        double distance = GetDistance();
        double pace = length / distance;

        return pace;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
}