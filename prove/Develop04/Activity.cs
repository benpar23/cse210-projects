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
        _duration = 50;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        
    }

    public void ShowSpinner(int seconds)
    {
        
    }

    public void ShowCountdown(int seconds)
    {
        
    }

    public void SetName (string name)
    {
        _name = name;
    }

    public void SetDescription (string description)
    {
        _description = description;
    }

    public void SetDuration (int duration)
    {
        _duration = duration;
    }
}