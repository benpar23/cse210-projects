using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        int magicNumber = randomGenerator.Next(1,100);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guessNumber = int.Parse(guess);


        while (guessNumber != magicNumber)
        {    if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
            }
        }

        Console.WriteLine("You guessed it!");
    }
}