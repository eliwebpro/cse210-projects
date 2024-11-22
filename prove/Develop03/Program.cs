using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

// external link https://stackoverflow.com/questions/77896952/how-to-choose-random-words-from-a-list-and-hide-them-with-underscores-in-c

class Program
{
    static void Main()
    {
        // Define the scripture reference and text
        
         List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Ether", 12, 27), "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."),
            new Scripture(new Reference("Alma", 32, 21), "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true."),
            new Scripture(new Reference("Mosiah", 2, 17), "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("Ether", 7, 27), "And there were no more wars in the days of Shule; and he remembered the great things that the Lord had done for his fathers in bringing them across the great deep into the promised land; wherefore he did execute judgment in righteousness all his days.")
        };


        // random Scripture 
        Random random = new Random();
        Scripture chosenScripture = scriptures[random.Next(scriptures.Count)];

        // Initial display scripture
        Console.WriteLine(chosenScripture.GetDisplayText());

        // Loop to hide words on Enter key press
        while (!chosenScripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input  == "quit" || input == "Quit" || input =="QUIT") break;

            // Hide a 4 random words each time
            chosenScripture.HideRandomWords(4);

            // Clear the console and display the updated scripture with the hidden words
            Console.Clear();
            Console.WriteLine(chosenScripture.GetDisplayText());
        }

        Console.WriteLine("\nAll words are hidden. Scripture memorization complete!");
    }
}
