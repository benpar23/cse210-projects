using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
       
        Running running = new Running("30 Nov 2023", 24, 3);

        Swimming swimming = new Swimming("04 Dec 2023", 30, 10);

        Cycling cycling = new Cycling("12 Dec 2023", 42, 10);

        activities.Add(running);
        activities.Add(swimming);
        activities.Add(cycling);

        Console.Clear();

        Console.WriteLine("Activity Log");
        Console.WriteLine("-------------------\r\n");

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.WriteLine();
    }
}