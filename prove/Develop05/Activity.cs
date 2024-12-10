using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {GetName()} activity.");
        Console.WriteLine(GetDescription());
        Console.Write("Enter the duration of the activity in seconds: ");
        SetDuration(int.Parse(Console.ReadLine()));
        Console.WriteLine("Get ready to begin...");
        PauseWithSpinner(3);
    }

    public void EndMessage()
    {
        Console.WriteLine("Good job! You have completed the activity.");
        Console.WriteLine($"You spent {GetDuration()} seconds on {GetName()}.");
        PauseWithSpinner(3);
    }

    protected void PauseWithSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        List<string> animationString = new List<string> { "|", "/", "-", "\\", "|" };
        int i = 0;  

        while (DateTime.Now < futureTime)
        {
            Console.Write(animationString[i]); 
            Thread.Sleep(300);  
            Console.Write("\b \b"); 

            i++; 
            if (i >= animationString.Count)  
            {
                i = 0; 
            }

            if (DateTime.Now >= futureTime)  
            {
                break;
            }
        }
    }

    public abstract void ExecuteActivity();
}
