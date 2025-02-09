class ReflectingActivity : Activity 
{
    protected List<string> _prompts;
    protected List<string> _questions;

    public ReflectingActivity() : base()
    {
        _name = "Reflecting Activity";
        _description = @"This activity will help you reflect on times in your life when you have shown strength and resilience.
This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you? ",
            "Have you ever done anything like this before? ",
            "How did you get started? ",
            "How did you feel when it was complete? ",
            "What made this time different than other times when you were not as successful? ",
            "What is your favorite thing about this experience? ",
            "What could you learn from this experience that applies to other situations? ",
            "What did you learn about yourself through this experience? ",
            "How can you keep this experience in mind in the future? "
        };
    }
    protected string GetRandomPrompt()
    {
        Random random = new();
        return _prompts[random.Next(_prompts.Count)];
    }

    protected string GetRandomQuestion()
    {
        Random random = new();
        return _questions[random.Next(_questions.Count)];
    }

    protected void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
        Console.Write("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        ShowCountDown(5, "You may begin in:");
        Console.Clear();
    }

    protected void DisplayQuestion()
    {
        Console.Write(GetRandomQuestion());
    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        int elapsed = 0;
        while (elapsed < _duration)
        {
            DisplayQuestion();
            ShowSpinner(5);
            elapsed += 5;
        }

        DisplayEndingMessage();

    }
}