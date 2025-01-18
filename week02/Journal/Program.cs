using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Journal journal = new Journal();
        PromptGenerators promptGenerator = new PromptGenerators();

    int UserInput;
    while (true)
    {
        journal.DisplayMenu();
        UserInput = int.Parse(Console.ReadLine());

        if (UserInput == 6)
        {
            break;
        }

        else if (UserInput == 1)
        {
            string prompt = promptGenerator.GetRandomPrompt();
            Console.WriteLine(prompt);
            Console.Write("> ");
            string journalEntry = Console.ReadLine();
            journal.AddEntry(new Entry(journalEntry, prompt));
        }

        else if (UserInput == 2)
        {
            journal.DisplayEntries();
        }

        else if (UserInput == 3)
        {
            Console.Write("Filename: ");
            journal.LoadFromFile(Console.ReadLine());
        }

        else if (UserInput == 4)
        {
            Console.Write("Filename: ");
            journal.SaveToFile(Console.ReadLine());
        }
        else if (UserInput == 5)
        {
            journal.DisplayEntries();
            Console.WriteLine("Enter the date and time of entry to delete: ");
            Console.WriteLine("Example 1/18/2025 2:14:55 PM.");
            string dateToDelete = Console.ReadLine();
            journal.DeleteEntry(dateToDelete);
        }

        numbers.Add(UserInput);
    }
    }
}