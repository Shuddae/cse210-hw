using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number");
            string userResponse = Console.ReadLine();
            number = int.Parse(userResponse);

            if (number != 0)
            {

            numbers.Add(number);

            }

        
        }
        
        int sum = 0;
        foreach (int userResponse in numbers)
        {
            sum += number;
        }
        
        Console.WriteLine($"The sum is: {sum}");


        // I totaly got lost from here and had to look at some of the sample ideas, 

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers [0];

        foreach (int userResponse in numbers)
        {
            if (number > max)
            {
                max = number;
            }

        } 
        Console.WriteLine($"The max is: {max}");
    }
}