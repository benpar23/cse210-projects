using System;

class Program
{   
    static void Main(string[] args)
    {
        int input = 0;

        while (input != 4)
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity\r\n2. Start reflecting activity\r\n3. Start listing activity\r\n4. Quit");
            Console.Write("Select a choice from the menu: ");
            input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                BreathingActivity newActivity = new BreathingActivity();

                Console.Clear();

                newActivity.DisplayStartingMessage();

                newActivity.Run();

                newActivity.DisplayEndingMessage();
            }
            else if (input == 2)
            {
                ReflectingActivity newActivity = new ReflectingActivity();

                Console.Clear();
                
                newActivity.DisplayStartingMessage();

                newActivity.Run();

                newActivity.DisplayEndingMessage();
            }
            else if (input == 3)
            {
                ListingActivity newActivity = new ListingActivity();
                
                Console.Clear();

                newActivity.DisplayStartingMessage();

                newActivity.Run();

                newActivity.DisplayEndingMessage();
            }
        }
    }
}   
