public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        string name = "Listing";

        string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";

        SetInfo(name, description);

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When you have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        List<string> list = GetListFromUser();
        _count = list.Count;
        Console.WriteLine($"You listed {_count} items!");
    }

    private void GetRandomPrompt()
    {
        Random random = new Random();

        int i = random.Next(_prompts.Count);

        string prompt = _prompts[i];

        Console.WriteLine($" --- {prompt} ---");          
    }

    private List<string> GetListFromUser()
    {
        List<string> list = new List<string>();

        int duration = GetDuration();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            list.Add(Console.ReadLine());
        }

        return list;
    }
}