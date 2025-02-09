using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n\n");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity.");
            Console.WriteLine("2. Start reflection activity.");
            Console.WriteLine("3. Start listing activity.");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu. ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                var breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                var reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (choice == "3")
            {
                var listingActivity = new ListingActivity();
                listingActivity.Run();
            } 
            else if (choice == "4")
            break;


        }
        
    }
}