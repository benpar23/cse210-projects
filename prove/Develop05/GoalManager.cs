using System.IO;
public class GoalManager
{
    List<Goal> _goals;
    int _score;
    string _level;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = "1";
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
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points -- Current Level: {_level}");
        Console.WriteLine();
    }

    public void ListGoalNames()
    {
        int i = 0;
        
        foreach (Goal goal in _goals)
        {
            i++;
            
            string goalDetails = goal.GetStringRepresentation();

            string[] first = goalDetails.Split(":");

            string[] details = first[1].Split(",");

            string goalName = details[0];

            Console.WriteLine($"{i}. {goalName}");
        }
    }

    public void ListGoalDetails()
    {
        int i = 0;

        Console.WriteLine("The goals are:");
        
        foreach (Goal goal in _goals)
        {
            i++;

            string details = goal.GetDetailsString();
            Console.WriteLine($"{i}. {details}");
        }
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

            ChecklistGoal newGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(newGoal);
        }
        else
        {
            Console.WriteLine("That is not a valid choice.");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int i = int.Parse(Console.ReadLine()) - 1;

        if (_goals[i].isComplete() == false)
        {
            _goals[i].RecordEvent();

            string goalDetails = _goals[i].GetStringRepresentation();

            string[] first = goalDetails.Split(":");

            string[] details = first[1].Split(",");

            string points = details[2];

            string type = first[0];

            if (type == "ChecklistGoal")
            {
                int total = int.Parse(details[3]) + int.Parse(points);

                if (_goals[i].isComplete())
                {
                    Console.WriteLine($"Congratulations! You have earned {total} points!");
                    _score += total;
                }
                else
                {
                    Console.WriteLine($"Congratulations! You have earned {points} points!");
                    _score += int.Parse(points);
                }
            }
            else
            {
                Console.WriteLine($"Congratulations! You have earned {points} points!");
                _score += int.Parse(points);
            }

            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
        }

        LevelUp();
    }

    public void SaveGoals()
    {
        Console.WriteLine("What would you like the file name to be?");

        string file = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(file))
        {
            sw.WriteLine($"{_score},{_level}");
            
            foreach (Goal goal in _goals)
            {
                sw.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the file name?");

        string file = Console.ReadLine();

        string[] lines = File.ReadAllLines(file);

        string[] firstLine = lines[0].Split(",");

        _score = int.Parse(firstLine[0]);
        _level = firstLine[1];

        foreach (string line in lines.Skip(1))
        {
            string[] first = line.Split(":");
            
            string[] parts = first[1].Split(",");

            if (first[0] == "SimpleGoal")
            {
                SimpleGoal newGoal = new SimpleGoal(parts[0], parts[1], parts[2]);

                if (parts[3] == "True")
                {
                    newGoal.RecordEvent();
                }

                _goals.Add(newGoal);
            }
            else if (first[0] == "EternalGoal")
            {
                EternalGoal newGoal = new EternalGoal(parts[0], parts[1], parts[2]);

                _goals.Add(newGoal);
            }
            else if (first[0] == "ChecklistGoal")
            {
                ChecklistGoal newGoal = new ChecklistGoal(parts[0], parts[1], parts[2], int.Parse(parts[4]), int.Parse(parts[3]));

                int amountCompleted = int.Parse(parts[5]);

                for (int i = 0; i < amountCompleted; i++)
                {
                    newGoal.RecordEvent();
                }

                _goals.Add(newGoal);
            }
        }
    }

    public void LevelUp()
    {
        if (_score < 500)
        {
            _level = "1";
        }
        else if (_score >= 500)
        {
            _level = "2";
        }
        else if (_score >= 1150)
        {
            _level = "3";
        }
        else if (_score >= 2645)
        {
            _level = "4";
        }
        else if (_score >= 6084)
        {
            _level = "5";
        }
        else
        {
            _level = "Master";
        }
    }
}