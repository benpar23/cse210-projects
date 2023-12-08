using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video one = new Video("10 Ways to Succeed", "Tai Lopez", 300);
        one.CreateComment("Ben Parada", "This video sucks lol");
        one.CreateComment("user9940", "Pretty inspiring actually");
        one.CreateComment("DrLupo", "number 2 was facts");
        one.CreateComment("Ninja", "Im better than this guy lollll");
        videos.Add(one);

        Video two = new Video("Found a dog at the zoo!", "Myth", 600);
        two.CreateComment("Edward Tenz", "I remember I had a dog like this back in the day");
        two.CreateComment("Jessica Blevins", "OMG so cuuutttee");
        two.CreateComment("Pieintheface", "You should pie the dog in the face");
        two.CreateComment("Petunia", "Bark bark lol");
        videos.Add(two);

        Video three = new Video("Spicy Garlic Chicken Recipe", "Jessica Seinfeld", 1300);
        three.CreateComment("Radiohead", "This chicken looks so good!");
        three.CreateComment("Jim Carrey", "Woah nelly that's a SPIICY MEATBALL");
        three.CreateComment("Shaquille O'Neal", "shaq a chef too");
        three.CreateComment("GabbyCat", "thanks for showing us how to make this, definitely gonna try it tonight!");
        videos.Add(three);

        foreach (Video video in videos)
        {
            Console.WriteLine();
            video.DisplayInfo();
        }
    }
}