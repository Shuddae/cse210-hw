using System;

public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
<<<<<<< HEAD
        Console.WriteLine("What was the most important thing you did today?");
=======
        _entries.Add(newEntry);
>>>>>>> 336f8408c660b6c05aa8ff0f1975fe14b53de11f
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }
<<<<<<< HEAD

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {

    }
=======
    
>>>>>>> 336f8408c660b6c05aa8ff0f1975fe14b53de11f
}