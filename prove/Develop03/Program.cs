using System;

// Exceeded program requirements by allowing the program to grab a random scripture from a file (scriptures.txt) and properly display it for the Memorizer program.
class Program
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("scriptures.txt");

        Random random = new Random();

        int randomScripture = random.Next(lines.Count());

        string[] parts = lines[randomScripture].Split('|');

        string scriptureBook = parts[0];
        int scriptureChapter = int.Parse(parts[1]);
        int scriptureStartVerse = int.Parse(parts[2]);
        int scriptureEndVerse = -5;
        
        if (parts[3] != " ")
        {
            scriptureEndVerse = int.Parse(parts[3]);
        }
        
        string scriptureText = parts[4];

        Reference newRef;

        if (scriptureEndVerse != -5)
        {
            newRef = new Reference(scriptureBook, scriptureChapter, scriptureStartVerse, scriptureEndVerse);
        }
        else
        {
            newRef = new Reference(scriptureBook, scriptureChapter, scriptureStartVerse);
        }
        
        Scripture scripture = new Scripture(newRef,scriptureText);

        Console.Clear();

        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine();

        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        string userInput = Console.ReadLine();

        while (userInput != "quit")
        {
            scripture.HideRandomWords(3);

            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden() == true)
            {
                break;
            }
            
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();
        }
    }
}