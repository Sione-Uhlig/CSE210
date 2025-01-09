using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = GetUserName();
        int UserNumber =  FavoriteNumber();
        int SquaredNumber = NumberSquared(UserNumber);
        Display(userName, SquaredNumber);
    }

    static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

    static string GetUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int FavoriteNumber()
    {
        Console.Write("please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int NumberSquared(int number)
    {
        int square = number * number;
        return square;
    }

    static void Display(string name, int square)
    {
        Console.Write($"{name}, the square of your number is {square}");
    }


}