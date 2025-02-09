public class Activity 
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;

    }


        protected void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name}\n");
            Console.WriteLine($"{_description}\n");
            Console.Write("How long, in seconds, would you like for your session? ");
            _duration = int.Parse(Console.ReadLine());
            Console.WriteLine("\nGet Ready!");
            ShowSpinner(5);
        }

        protected void DisplayEndingMessage()
        {
            Console.WriteLine("Well Done!!");
            ShowSpinner(3);
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
            ShowSpinner(3);

        }

        protected void ShowSpinner(int seconds)
        {
            List<string> animationStrings = new List<string>
            {
                "|", "/", "-", "\\", "|", "/", "-", "\\"
            };

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);

            int i = 0;
            while (DateTime.Now < endTime)
            {
                string s = animationStrings[i];
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");

                i++;
                if (i >= animationStrings.Count)
                {
                    i = 0;
                }
            }
            Console.WriteLine();
        }

        protected void ShowCountDown(int seconds, string message)
    {
        Console.Write($"{message} ");
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i > 0)  
            {
                Console.Write("\b \b"); 
            }
        }
        Console.WriteLine(); 
    }



    
}