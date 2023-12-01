public class Checklist : Goal
{
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