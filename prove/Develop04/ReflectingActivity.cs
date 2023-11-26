public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity()
    {
        string name = "Reflecting";

        string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        SetInfo(name, description);

        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of your most cherished memory."); 
        _prompts.Add("Think back to a significant family memory.");
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        int duration = GetDuration();

        int questionNumber = duration / 10;

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:\r\n");
        DisplayPrompt();
        Console.WriteLine("\r\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\r\nNow ponder on each of the following questions as they relate to this experience.");
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