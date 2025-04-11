using System;

public abstract class Activity
{
     private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} Activity ---");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nPrepare to begin...");
        Spinner(3);
    }

    public void End()
    {
        Console.WriteLine("\nGreat job!");
        Spinner(2);
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        Spinner(2);
    }

    public int GetDuration() => _duration;

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}... ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void Spinner(int seconds)
    {
        string[] spinnerChars = { "|", "/", "-", "\\" };
        int end = Environment.TickCount + seconds * 1000;

        int i = 0;
        while (Environment.TickCount < end)
        {
            Console.Write($"\r{spinnerChars[i % spinnerChars.Length]}");
            Thread.Sleep(200);
            i++;
        }
        Console.Write("\r ");
        Console.WriteLine();
    }

    public abstract void Perform();

}
