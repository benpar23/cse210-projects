public class Checklist : Goal
{
    int _amountCompleted;
    int _target;
    int _bonus;

    public Checklist(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    
    public override void RecordEvent()
    {
        
    }

    public override bool isComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return "different";
    }

    public override string GetStringRepresentation()
    {
        return "2";
    }
}