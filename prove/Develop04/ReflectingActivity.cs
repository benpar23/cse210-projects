public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>{"Think of a time when you did something really difficult.", "Think of your most cherished memory.", "Think back to a significant family memory.", "Think of a time when you stood up for someone else.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string>{"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};

    public ReflectingActivity()
    {
        string name = "Reflecting";

        string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        SetInfo(name, description);
    }

    public void Run()
    {
        int duration = GetDuration();

        int questionNumber = duration / 10;

        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.Clear();

        for (int i = questionNumber; i > 0; i--)
        {
            DisplayQuestion();
            ShowSpinner(10);
            Console.WriteLine();
        }

    }

    private string GetRandomPrompt()
    {
        Random random = new Random();

        int i = random.Next(_prompts.Count);

        return _prompts[i];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();

        int i = random.Next(_questions.Count);

        return _questions[i];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($" --- {prompt} ---");
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.Write($"> {question} ");
    }


}