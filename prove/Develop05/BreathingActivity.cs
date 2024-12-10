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
        ShowAnimation();  // Mostrar a animação de pontos enquanto respira
        duration -= 3;

        if (duration <= 0) break;

        Console.WriteLine("Breathe out...");
        ShowAnimation();  // Mostrar a animação de pontos enquanto respira
        duration -= 3;
    }
    EndMessage();
}

private void ShowAnimation()
{
    string dots = "";
    int count = 0;
    
    // Mostrar pontos para a animação
    while (count < 3)
    {
        dots += ".";  // Adiciona um ponto
        Console.Write(dots);  // Exibe os pontos
        Thread.Sleep(1500);  // Pausa de 500ms
        Console.Write("\b \b");  // Apaga o último ponto
        count++;  // Incrementa o contador
    }
    Console.WriteLine();  // Pula para a próxima linha após a animação de pontos
}

}
