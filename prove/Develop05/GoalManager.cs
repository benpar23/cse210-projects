using System.IO;
public class GoalManager
{
    List<Goal> _goals;
    int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int choice = 0;
        
        while (choice != 6)
        {
            DisplayPlayerInfo();
            
            Console.WriteLine("Menu Options:\r\n1. Create New Goal\r\n2. List Goals\r\n3. Save Goals\r\n4. Load Goals\r\n5. Record Event\r\n6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            
            
            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoalDetails();
            }
            else if (choice == 3)
            {
                SaveGoals();
            }
            else if (choice == 4)
            {
                LoadGoals();
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            int i = 1;
            
            Console.WriteLine($"{i}. {goal}");
        }
    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {
        int goalChoice = 0;
        
        Console.WriteLine("The types of goals are:\r\n1. Simple Goal\r\n2. Eternal Goal\r\n3. Checklist Goal");
        Console.Write("What kind of goal would you like to create? ");
        goalChoice = int.Parse(Console.ReadLine());

        if (goalChoice == 1)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            SimpleGoal newGoal = new SimpleGoal(name, description, points);
            _goals.Add(newGoal);
        }
        else if (goalChoice == 2)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            EternalGoal newGoal = new EternalGoal(name, description, points);
            _goals.Add(newGoal);
        }
        else if (goalChoice == 3)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            Console.Write("How many times does this goal need to completed for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            Checklist newGoal = new Checklist(name, description, points, target, bonus);
            _goals.Add(newGoal);
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
    }

    public void SaveGoals()
    {
        Console.WriteLine("What would you like the file name to be?");

        string file = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(file))
        {
            // sw.WriteLine($"{_name}'s Journal");
            
            // foreach (Entry entry in _entries)
            // {
            //     sw.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}");
            // }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the file name?");

        string file = Console.ReadLine();


    }


}