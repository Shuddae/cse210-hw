using System;

public class Entry
{
    public String _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"{_date} {_promptText} {_entryText}");
    }
}