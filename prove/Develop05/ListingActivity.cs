using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "What are some positive memories you cherish?"
    };

    public ListingActivity()
    {
        SetName("Listing");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can.");
    }

    public override void ExecuteActivity()
    {
        StartMessage();
        Console.WriteLine(_prompts[new Random().Next(_prompts.Count)]);
        PauseWithSpinner(5);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter a name: ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {items.Count} items.");
        EndMessage();
    }
}
