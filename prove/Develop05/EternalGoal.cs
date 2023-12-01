public class EternalGoal : Goal
{
    public override void RecordEvent()
    {
        
    }

    public override bool isComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return "3";
    }
}