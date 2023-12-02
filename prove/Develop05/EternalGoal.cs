public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        
    }
    
    public override void RecordEvent()
    {
        string goalDetails = GetStringRepresentation();

        string[] first = goalDetails.Split(":");

        string[] details = first[1].Split(",");

        string points = details[2];

        Console.WriteLine($"Congratulations! You have earned {points} points!");
    }

    public override bool isComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}