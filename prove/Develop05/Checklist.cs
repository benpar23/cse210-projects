public class Checklist : Goal
{
    int _amountCompleted;
    int _target;
    int _bonus;

    public Checklist(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    
    public override void RecordEvent()
    {
        
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
        return $"[ ] {_shortName} ({_description} -- Currently completed: {_amountCompleted}/{_target})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}