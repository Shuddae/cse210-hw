using System;

class Program
{

     static Journal journal = new Journal();
    static PromptGenerator generator = new PromptGenerator();
        static void Main(string[] args)
    {
        while (true)
        {
             Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save to file");
            Console.WriteLine("4. Load from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();
        }
        
    }

    public void SaveToFile(string file)
    {
         Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
    }

    public void LoadFromFile(string file)
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
    }
}