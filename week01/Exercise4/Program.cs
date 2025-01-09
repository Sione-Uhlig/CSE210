using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();


        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int UserInput;
        while (true)
        {
            Console.Write("Enter number: ");
            UserInput = int.Parse(Console.ReadLine());

            if (UserInput == 0)
            {
                break;
            }

            numbers.Add(UserInput);
        }

        double avg = numbers.Average();
        int sum = numbers.Sum();
        int largest = numbers.Max();

        Console.WriteLine($"The sum is: {sum}.");
        Console.WriteLine($"The average is: {avg}.");
        Console.WriteLine($"The largest number is: {largest}.");

    }
}