using System;

public class GoalManager
{
    private List<Goal>_goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine(DisplayPlayerInfo());
            Console.WriteLine($"Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                running = false;
            }
        }
    }

    private string DisplayPlayerInfo()
    {
        return $"\nYou have {_score} points!\n";
    }

    private void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]._shortName}");
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Please select the goal type you would like to create. ");


        string goalType = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        if (goalType == "1")
        {
            goal = new SimpleGoal(name, description, points);
        }

        else if (goalType == "2")
        {
            goal = new EternalGoal(name, description, points);
        }

        else if ( goalType == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            goal = new ChecklistGoal(name, description, points, target, bonus);
        }

         _goals.Add(goal);
    }

    private void RecordEvent()
{
    if (_goals.Count == 0) return;

    Console.WriteLine("\nThe goals are:");
    for (int i = 0; i < _goals.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {_goals[i]._shortName}");
    }

    Console.Write("\nWhich goal did you accomplish? ");
    int index = int.Parse(Console.ReadLine()) - 1;
    
    if (index >= 0 && index < _goals.Count)
    {
        Goal goal = _goals[index];
        goal.RecordEvent();
        
        int pointsEarned;
        if (goal is ChecklistGoal checklistGoal)
        {
            if (checklistGoal.IsComplete())
            {
                pointsEarned = checklistGoal._points + checklistGoal._bonus;
            }
            else
            {
                pointsEarned = checklistGoal._points;
            }
        }
        else
        {
            pointsEarned = goal._points;
        }
        
        _score += pointsEarned;
        Console.WriteLine($"\nCongratulations! You have earned {pointsEarned} points!");
        Console.WriteLine($"You now have {_score} points.");
    }
}

    private void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        List<string> lines = new List<string>();
        lines.Add(_score.ToString());
        
        foreach (Goal goal in _goals)
        {
            lines.Add(goal.GetStringRepresentation());
        }
        
        File.WriteAllLines("goals.txt", lines);
    }

    private void LoadGoals()
    {
        Console.Write("Enter the file name to load your goals: ");
        string fileName = Console.ReadLine();


        string[] lines = File.ReadAllLines(fileName);
        _goals.Clear();
        
        if (lines.Length > 0)
        {
            _score = int.Parse(lines[0]);
            
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("|");
                if (parts.Length < 4) continue;

                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (type == "SimpleGoal" && parts.Length >= 5)
                {
                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    if (bool.Parse(parts[4]))
                    {
                        goal.RecordEvent();
                    }
                    _goals.Add(goal);
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(name, description, points));
                }
                else if (type == "ChecklistGoal" && parts.Length >= 7)
                {
                    int amountCompleted = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);
                    
                    ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                    for (int j = 0; j < amountCompleted; j++)
                    {
                        goal.RecordEvent();
                    }
                    _goals.Add(goal);
                }
            }
        }
    }

}

