using System;
class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        Journal newJournal = new Journal();
        
        
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:\r\n1. Write\r\n2. Display\r\n3. Load\r\n4. Save\r\n5. Quit");

            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Entry newEntry = new Entry();

                PromptGenerator _prompt = new PromptGenerator();

                newEntry._promptText = _prompt.GetRandomPrompt();

                Console.WriteLine(newEntry._promptText);

                newEntry._entryText = Console.ReadLine();

                DateTime _date = DateTime.Now;

                newEntry._date = _date.ToString("dd MMMM yyyy");

                newJournal.AddEntry(newEntry);
            }

            else if (choice == 2)
            {
                newJournal.DisplayAll();
            }

            else if (choice == 3)
            {
                newJournal = new Journal();

                newJournal.LoadFromFile(Console.ReadLine());
            }

            else if (choice == 4)
            {
                newJournal.SaveToFile(Console.ReadLine());
            }
        }
    }
}