using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string response;

        do 
        {

            Console.Write("Do you want to continue? yes no ");
            response = Console.ReadLine().ToLower();

            if (response == "no") break;

            Console.Write("Guess a number between 1 and 10. ");

            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);

            int guess = 0;

            while (guess != number)
            {

                Console.Write("\nWhat is your guess?  ");
                guess = int.Parse(Console.ReadLine());

                if (number > guess )
                {
                    Console.Write("Higher");
                }

                else if (number < guess )
                {
                    Console.Write("Lower");
                }

                else if (number == guess)
                {
                    Console.Write("You guessed it!\n");
                }
            }
        } while (response == "yes");

        Console.Write("Thanks for playing.");

    }
}