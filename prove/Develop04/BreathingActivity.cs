public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        string name = "Breathing";

        string description = "This activity will help you relax by walking through your breathing in and out slowly. Clear your mind and focus on your breathing.";

        SetInfo(name, description);
    }

    public void Run()
    {
        int duration = GetDuration();

        int breaths = duration / 5;

        for (int i = breaths; i > 0; i = i - 2)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountdown(6);
            Console.WriteLine();
        }
    }
}