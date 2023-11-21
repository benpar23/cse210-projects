using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment homework = new Assignment("Ben Parada", "Geography");

        Console.WriteLine(homework.GetSummary());
    }
}