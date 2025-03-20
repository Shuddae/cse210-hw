using System;

public class Entry
{
    public String _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
<<<<<<< HEAD
        Console.WriteLine($"{_date} {_promptText} {_entryText}");
=======
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine(); 
>>>>>>> 336f8408c660b6c05aa8ff0f1975fe14b53de11f
    }
}