using System;

public class ListingActivity : Activity
{
       private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base(
        "Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }

    public override void Perform()
    {
        Start();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");

        Console.WriteLine("\nYou will have a few seconds to think about it...");
        Countdown(5);

        Console.WriteLine("\nStart listing items. Press Enter after each one:");

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    responses.Add(input);
                }
            }
        }

        Console.WriteLine($"\nYou listed {responses.Count} items.");
        End();
    }   
}