using System;

class Program
{
    static void Main(string[] args)
    {   
        // To exceed program requirements, I added the LevelUp method in the GoalManager class and the ability to showcase what level the user is at based on how many points they've accumulated.
        
        GoalManager goals = new GoalManager();

        goals.Start();
    }
}