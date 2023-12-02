public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;

        string goalDetails = GetStringRepresentation();

        string[] first = goalDetails.Split(":");

        string[] details = first[1].Split(",");

        string points = details[2];

        Console.WriteLine($"Congratulations! You have earned {points} points!");
    }

    public override bool isComplete()
    {
        if (_isComplete == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}