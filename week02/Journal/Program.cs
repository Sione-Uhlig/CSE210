using System;

class Program
{
    static void Main(string[] args)
    {
         List<int> numbers = new List<int>();
        List<string> _entries = new List<string>();

    int UserInput;
    while (true)
    {
        PromptGenerators promptGenerator = new PromptGenerators();
        Journal journal = new Journal();
        journal.DisplayMenu();
        UserInput = int.Parse(Console.ReadLine());

        if (UserInput == 5)
        {
            break;
        }

        else if (UserInput == 1)
        {
            promptGenerator.DisplayRandomPrompt();
            Console.Write("> ");
            string journalEntry = Console.ReadLine();
            _entries.Add(journalEntry);
        }

        else if (UserInput == 2)
        {
            foreach (string entry in _entries)
            {
                Console.WriteLine(entry);
            }
        }

        numbers.Add(UserInput);
    }
    }
}