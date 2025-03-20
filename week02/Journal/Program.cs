using System;

class Program
{
    
    static Journal journal = new Journal();
    static PromptGenerator generator = new PromptGenerator();


    static void Main(string[] args)
    {
<<<<<<< HEAD
         Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        Console.WriteLine("Welcome to the Jornal Program!");

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            if (choice == "1")
             {
                    string selectedPrompt = promptGen.GetRandomPrompt();
                    Console.WriteLine(selectedPrompt);
                    string response = Console.ReadLine();
                    Entry newEntry = new Entry (selectedPrompt,response);
                    journal.AddEntry(newEntry);
               }
               else if (choice == "2")
               {
                    journal.DisplayAll();
               }
                else if (choice == "3")
                {
                    journal.LoadFromFile();
                }
                else if (choice == "4")
                 {
                    journal.SaveToFile();
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Goodbye!");
                    break;
=======
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
>>>>>>> 336f8408c660b6c05aa8ff0f1975fe14b53de11f
    }
    

}