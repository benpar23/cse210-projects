using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();

        int gradePercent = int.Parse(grade);

        if (gradePercent < 60)
        {
            string letterGrade = "F";
        }
        else if (gradePercent < 70)
        {
            string letterGrade = "D";
        }
        else if (gradePercent < 80)
        {
            string letterGrade = "C";
        }

    }
}