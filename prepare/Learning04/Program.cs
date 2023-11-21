using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment homework = new Assignment ("Ben Parada", "English");

        MathAssignment math = new MathAssignment ("Autumn Parada", "Multiplication", "8.2", "20-25");        
        
        WritingAssignment essay = new WritingAssignment("Estrella Parada", "Geography", "The World is Not Flat");

        Console.WriteLine(homework.GetSummary());

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        Console.WriteLine(essay.GetSummary());
        Console.WriteLine(essay.GetWritingInformation());
    }
}