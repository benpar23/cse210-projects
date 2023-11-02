using System;

using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        
        int number= -1;

        int max = 0;

        int smallest = 999999;
        
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");

        while (number != 0)
        {
            number = int.Parse(Console.ReadLine());
            
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;

        foreach (int numero in numbers)
        {
            sum += numero;
        }

        float average = ((float)sum)/numbers.Count;

        foreach (int smallNumber in numbers)
        {
            if (smallNumber < smallest && smallNumber > 0)
            {
                smallest = smallNumber;
            }
        }

        foreach (int bigNumber in numbers)
        {
            if (bigNumber > max)
            {
                max = bigNumber;
            }
        }

        Console.WriteLine($"The sum is: {sum}.");
        Console.WriteLine($"The average is: {average}.");
        Console.WriteLine($"The largest number is {max}.");
        Console.WriteLine($"The smallest number is {smallest}.");
    }
}