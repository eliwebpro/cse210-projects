using System;
// links of help
// https://video.byui.edu/media/t/1_uoyhkbf2 
// https://stackoverflow.com/questions/77238547/vs-code-simple-console-journal-program-issue
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Journal journal = new Journal();
        Prompt prompt = new Prompt();
        Entry entry = new Entry();


        Console.WriteLine("Welcome back to your Daily Journal!");


        while (true)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Type your Choice below. ");

            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                string chosenPrompt = prompt.GetRandomPrompt();
                Console.WriteLine($" {chosenPrompt}");
                
                Console.Write("Response: ");
                string response = Console.ReadLine();
                
                Entry newEntry = new Entry
                {
                    Prompt = chosenPrompt,
                    Response = response,
                    Date = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss")
                };
                journal.AddEntry(newEntry);
                Console.WriteLine("Entry saved.");
            }
            else if (userChoice == "2")
            {
                journal.DisplayEntries();
            }
            else if (userChoice == "3")
            {
                Console.Write("Please enter the filename you would like to save to: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Journal saved.");
            }
            else if (userChoice == "4")
            {
                Console.Write("Please enter the file name you would like to load from: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded.");
            }
            else if (userChoice == "5")
            {
                Console.WriteLine("Goodbye!");
                // what is the difference between break and return?
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please enter a number 1-5.");
                
            }
        }
    }
}
