public class ChecklistGoal : Goal
{
    int _amountCompleted;
    int _target;
    int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    
    public override void RecordEvent()
    {
        _amountCompleted += 1;
        
        string goalDetails = GetStringRepresentation();

        string[] first = goalDetails.Split(":");

        string[] details = first[1].Split(",");

        string points = details[2];

        Console.WriteLine($"Congratulations! You have earned {points} points!");
    }

    public override bool isComplete()
    {
        if (_amountCompleted / _target == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        bool complete = isComplete();

        if (complete)
        {
            return $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}