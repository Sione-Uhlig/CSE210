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
            Console.WriteLine($"\nYou have {_score} points!\n");
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
                Console.WriteLine("Listing the Goals");
            }
            else if (choice == "3")
            {
                Console.WriteLine(" Saving the Goals");
            }
            else if (choice == "4")
            {
                Console.WriteLine("Loading the Goals");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Recording the Events");
            }
            else if (choice == "6")
            {
                running = false;
            }
        }
    }

    private void DIsplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.")
    }
    
    private void CreateGoal()
    {
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Please select the goal type you would like to create. ");

        string goalType = Console.ReadLine();

        if (goalType == "1")
        {
            Console.WriteLine("Creating a Simple Goal");
        }

        else if (goalType == "2")
        {
            Console.WriteLine("Creating an Eternal Goal");
        }

        else if ( goalType == "3")
        {
            Console.WriteLine("Creating a Checklist Goal");
        }
    }

}

