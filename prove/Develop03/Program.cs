using System;

class Program
{
    static void Main(string[] args)
    {
        Word word = new Word("poo");
        Console.WriteLine(word.GetDisplayText());

        Reference newRef = new Reference("1 Nephi", 4, 16);
        Console.WriteLine(newRef.GetDisplayText());

        // string random = "birthday";

        // string randomHidden = new string('_',random.Length);

        // Console.WriteLine(randomHidden);

    }
}