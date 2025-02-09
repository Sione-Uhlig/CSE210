class BreathingActivity : Activity 
{
    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        int count = 0;
        while (count < _duration)
        {
            ShowCountDown(3, "Breathe in...");
            ShowCountDown(5, "Breathe out...");
            Console.WriteLine();
            count += 6;
        }
        
        DisplayEndingMessage();

    }
} 