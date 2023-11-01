using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();

        int gradePercent = int.Parse(grade);

        string letterGrade;

        if (gradePercent < 60)
        {
            letterGrade = "F";
        }
        else if (gradePercent < 70)
        {
            letterGrade = "D";
        }
        else if (gradePercent < 80)
        {
            letterGrade = "C";
        }
        else if (gradePercent < 90)
        {
            letterGrade = "B";
        }
        else
        {
            letterGrade = "A";
        }

        Console.WriteLine();


        Console.WriteLine($"Your current grade is {letterGrade}.");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations you are passing this course!");
        }
        else
        {
            Console.WriteLine("unfortunately you are not passing this course. Make sure you reach out to your instructor for help!");
        }

    }
}