using System;

class Program
{
    static void Main(string[] args)
    {
        Word word = new Word("poo");
        Console.WriteLine(word.GetDisplayText());

        Reference newRef = new Reference("1 Nephi", 4, 16);
        Console.WriteLine(newRef.GetDisplayText());

        Scripture scripture = new Scripture(newRef,"Matthew 5: 14-16|Ye are the light of the world. A city that is set on an hill cannot be hid. Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house. Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven.");

        Console.WriteLine(scripture.GetDisplayText());

        // string random = "birthday";

        // string randomHidden = new string('_',random.Length);

        // Console.WriteLine(randomHidden);

    }
}