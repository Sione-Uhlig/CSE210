class ListingActivity : Activity 
{
    protected int _count;
    protected List<String> _prompts;

    public ListingActivity() : base()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts = new List<String>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }


    protected void GetRandomPrompt()
    {
        Random random = new();
        Console.WriteLine($"--- {_prompts[random.Next(_prompts.Count)]} ---");
    }

    protected List<string> GetListFromUser()
    {
        List<string> items = new();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        _count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            items.Add(item);
            _count++;
        }
        return items;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetRandomPrompt();
        ShowCountDown(5, "You may begin in:");
        Console.WriteLine("Start listing items.\n");

        List<string> items = GetListFromUser();
        Console.WriteLine($"You listed {_count} items.\n");

        DisplayEndingMessage();
    }
}