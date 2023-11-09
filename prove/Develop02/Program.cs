using System;

class Program
{
    static void Main(string[] args)
    {
        Entry newEntry = new Entry();

        newEntry._date = DateTime.Now.ToString("dd MMMM yyyy");

        Console.WriteLine($"{newEntry._date}");
    }
}