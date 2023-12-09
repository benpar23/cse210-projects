public class Swimming : Activity
{
    private double _swimmingLaps;

    public Swimming(string date, double length, double numberOfLaps) : base(date, length)
    {
        _swimmingLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        double distance = _swimmingLaps * 50 / 1000;

        return distance;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        double length = GetLength();
        double pace = length / distance;

        return pace;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        double length = GetLength();
        double speed = distance / length * 60;

        return speed;
    }
}