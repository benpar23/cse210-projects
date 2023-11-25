using System.Dynamic;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {
        _name = "";
        _description = "description";
        _duration = 30;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animations = new List<string>();
        
        animations.Add("|");
        animations.Add("/");
        animations.Add("–");
        animations.Add("\\");
        animations.Add("|");
        animations.Add("/");
        animations.Add("–");
        animations.Add("\\");
    

        // foreach (string s in animations)
        // {
        //     Console.Write(s);
        //     Thread.Sleep(250);
        //     Console.Write("\b \b");
        // }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animations[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= animations.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
        }
    }

    // public void SetName (string name)
    // {
    //     _name = name;
    // }

    // public void SetDescription (string description)
    // {
    //     _description = description;
    // }

    // public void SetDuration (int duration)
    // {
    //     _duration = duration;
    // }

    public void SetInfo (string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
}