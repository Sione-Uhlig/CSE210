using System;
using System.ComponentModel.Design;


// I added a menu to the program so that you could memorize multiple scriptures. 
class Program
{
    static void Main(string[] args)
    {

        while (true)

        {
            DisplayMenu();
            string option = Console.ReadLine();

            if (option == "1")
            {
                scripture1().StartMemorization();
            }
            if (option == "2")
            {
                scripture2().StartMemorization();
            }
            if (option == "3")
            {
                scripture3().StartMemorization();
            }
            if (option == "4" || option.ToLower() == "quit")
            {
                break;
            }

        }

        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Please Select an option to continue! ");
            Console.WriteLine("1. John 3:16");
            Console.WriteLine("2. Proverbs 3:5-6");
            Console.WriteLine("3. Ether 12:27");
            Console.WriteLine("4. Exit");
        }

        Scripture scripture1()
        {
            return new Scripture(
                new Reference("John", 3, 16),
            "For God so loved the world that he gave his one and only Son, " +
            "that whoever believes in him shall not perish but have eternal life.");
        }

        Scripture scripture2()
        {
            return new Scripture(
                new Reference("Proverbs", 3, 5, 6), 
            "Trust in the Lord with all your heart and lean not on your own understanding; " +
            "in all your ways submit to him, and he will make your paths straight.");
        }

        Scripture scripture3()
        {
            return new Scripture(
                new Reference("Ether", 12, 27),
            "And if men come unto me I will show unto them their weakness." + 
            " I give unto men weakness that they may be humble; and my grace is sufficient" +
            " for all men that humble themselves before me; for if they humble themselves" + 
            " before me, and have faith in me, then will I make weak things become strong unto them.");
        }


    }
}