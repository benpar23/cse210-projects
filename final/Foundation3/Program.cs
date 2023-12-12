using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        
        OutdoorGathering outdoorGathering = new OutdoorGathering("Hoedown", "Come join us for a fun-filled day at the ranch with a good old fashioned howdown! Dancing, great food and drink, and awesome company will make this an event you won't forget!", "Jun. 7th, 2024", "6:00p.m.", "Sunny");

        outdoorGathering.SetAddress("123 Main St", "Atlanta", "Georgia", "USA");

        events.Add(outdoorGathering);

        Lecture lecture = new Lecture("The Secrets of the Universe", "Join us as we learn from Professor Oak about different aspects of our ever expanding universe, from space to planets to ecosystems.", "Feb. 24th, 2024", "5:00pm", "Professor Oak", 300);

        lecture.SetAddress("45 Wallaby Way", "Hartford", "Connecticut", "USA");

        events.Add(lecture);

        Reception reception = new Reception("Brian and Wendy's Wedding", "We would like to invite you to celebrate the union of Brian Henry Adams & Wendy Mary Frech in holy matrimony.", "Sept. 20th, 2025", "7:00 pm", "Please RSVP to brianadamwedding@gmail.com by July 1st, 2025");

        reception.SetAddress("29 Stayner Drive", "Kitchener", "Ontario", "Canada");

        events.Add(reception);

        foreach (Event e in events)
        {
            Console.WriteLine();
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine();
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine("--------------------------------------");
        }
    }
}