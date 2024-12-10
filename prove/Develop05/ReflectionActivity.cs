using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?"
    };

    public ReflectionActivity()
    {
        SetName("Reflection");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience.");
    }

    public override void ExecuteActivity()
    {
        StartMessage();
        Console.WriteLine(_prompts[new Random().Next(_prompts.Count)]);
        PauseWithSpinner(3);

        int duration = GetDuration();
        while (duration > 0)
        {
            Console.WriteLine(_questions[new Random().Next(_questions.Count)]);
            PauseWithSpinner(5);
            duration -= 5;
        }
        EndMessage();
    }
}
