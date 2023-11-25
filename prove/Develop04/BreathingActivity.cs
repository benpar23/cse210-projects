public class BreathingActivity : Activity
{
    public BreathingActivity(int duration)
    {
        string name = "Breathing";
        // SetName(name);

        string description = "This activity will help you relax by walking through your breathing in and out slowly. Clear your mind and focus on your breathing.";
        // SetDescription(description);

        // SetDuration(duration);

        SetInfo(name,description,duration);
    }

    public void Run()
    {
        
    }
}