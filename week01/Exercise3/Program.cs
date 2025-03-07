using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        int magicNumber = int.Parse (Console.ReadLine());

        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 11);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine("What us your guess?");
            int Number = int.Parse(Console.ReadLine());
        }

        if ( magicNumber > guess)
        {
            Console.WriteLine("higher");
        }
        else if (magicNumber < guess)
        {
            Console.WriteLine("lower");
        }

        else
        {
            Console.WriteLine("You guessed it right!");
        }



        
    }
}