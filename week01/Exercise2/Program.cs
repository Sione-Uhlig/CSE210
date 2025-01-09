using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("\nWhat was the percentage you receive?. ");
        string input = Console.ReadLine();

        int grade = int.Parse(input);

        string LetterGrade = "";

        if (grade >= 90)
        {
            LetterGrade = "A";
        }

        else if (grade >= 80)
        {
            LetterGrade = "B";
        }

          else if (grade >= 70)
        {
            LetterGrade = "C";
        }

          else if (grade >= 60)
        {
            LetterGrade = "D";
        }

          else
        {
            LetterGrade = "F";
        }

        Console.WriteLine($"\nYou received a(n) {LetterGrade} for your class. ");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you passed the class! \n");
        }

        else 
        {
            Console.WriteLine("you will need to try again next semester. \n");
        }

    }
}