using System;

class Program
{
    static void Main(string[] args)
    {
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
    }
}