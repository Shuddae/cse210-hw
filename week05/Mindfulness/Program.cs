using System;

class Program
{
    static void Main(string[] args)
    {
         while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an activity: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Start();
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Start();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Start();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid activity.");
                    System.Threading.Thread.Sleep(2000);
                    break;
            }
        }
    }
    
}