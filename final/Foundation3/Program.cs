using System;

class Program
{
    static void Main(string[] args)
    {
        OutdoorGathering first = new OutdoorGathering("Hoedown", "Come join us for a fun-filled day at the ranch with a good old fashioned howdown! Dancing, great food and drink, and awesome company will make this an event you won't forget!", "07/06/24", "6:00p.m.", "Sunny");

        first.SetAddress("123 Main St", "Atlanta", "Georgia", "USA");

        Console.WriteLine(first.GetFullDetails());
    }
}