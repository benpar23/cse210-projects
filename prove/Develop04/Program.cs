using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

class Program
{   
    static void Main(string[] args)
    {
        int input = -1;

        while (input != 4)
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity\r\n2. Start reflecting activity\r\n3. Start listing activity\r\n4. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity newActivity = new BreathingActivity();

                Console.Clear();

                newActivity.DisplayStartingMessage();

                newActivity.Run();

                newActivity.DisplayEndingMessage();
            }
            else if (choice == 2)
            {
                ReflectingActivity newActivity = new ReflectingActivity();

                Console.Clear();
                
                newActivity.DisplayStartingMessage();

                newActivity.DisplayEndingMessage();
            }
        }
    }
}   
