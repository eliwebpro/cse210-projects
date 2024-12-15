using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("Breathing");
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public override void ExecuteActivity()
{
    StartMessage();
    int duration = GetDuration();
    while (duration > 0)
    {
        Console.WriteLine("Breathe in...");
        ShowAnimation();  
        duration -= 3;

        if (duration <= 0) break;

        Console.WriteLine("Breathe out...");
        ShowAnimation();  
        duration -= 3;
    }
    EndMessage();
}

private void ShowAnimation()
{
    for (int i = 1; i <= 3; i++)
    {
        string dots = new string('.', i);

        Console.Write(dots);

        Thread.Sleep(1500);
        for (int delet = 0; delet < i; delet++)
        {
            Console.Write("\b \b");
        }
    }

    Console.WriteLine();
}


}
