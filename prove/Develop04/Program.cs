using System;

// In order to exceed requirements, I have added the ability to check how many times certain activities have been completed (logging activity counts) and the ability to then display these counts as a menu option.
class Program
{   
    static void Main(string[] args)
    {
        int input = 0;

        int breathingLog = 0;
        int reflectingLog = 0;
        int listingLog = 0;

        while (input != 5)
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity\r\n2. Start reflecting activity\r\n3. Start listing activity\r\n4. Activity Log\r\n5. Quit");
            Console.Write("Select a choice from the menu: ");
            input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                BreathingActivity newActivity = new BreathingActivity();

                Console.Clear();

                newActivity.DisplayStartingMessage();

                newActivity.Run();

                newActivity.DisplayEndingMessage();
                breathingLog++;
            }
            else if (input == 2)
            {
                ReflectingActivity newActivity = new ReflectingActivity();

                Console.Clear();
                
                newActivity.DisplayStartingMessage();

                newActivity.Run();

                newActivity.DisplayEndingMessage();

                reflectingLog++;
            }
            else if (input == 3)
            {
                ListingActivity newActivity = new ListingActivity();
                
                Console.Clear();

                newActivity.DisplayStartingMessage();

                newActivity.Run();

                newActivity.DisplayEndingMessage();

                listingLog++;
            }
            else if (input == 4)
            {
                Console.Clear();

                Console.WriteLine("Activities Performed\r\n");
                Console.WriteLine($"Breathing Activity: {breathingLog}");
                Console.WriteLine($"Reflecting Activity: {reflectingLog}");
                Console.WriteLine($"Listing Activity: {listingLog}");

                Console.WriteLine();
                Console.Write("Press enter to continue. ");
                Console.ReadLine();
            }
        }
    }
}   
