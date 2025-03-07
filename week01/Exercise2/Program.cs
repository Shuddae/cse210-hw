using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your course grade percentage: ");
        string percent =  Console.ReadLine();

        int grade = int.Parse(percent);

        string letter;

        if ( grade >= 90)
        {
            letter = "A";
        }

        else if ( grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grades are: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations You have Passed ****");

        }

        else 
        {
           Console.WriteLine("Better luck next time");
        }


    }
}