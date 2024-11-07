using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("Let's play a game. I'll pick a number between 1-100, and you have to guess it.");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = 0;
        int attempts = 0; 

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            attempts++; 

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {attempts} attempts to guess the correct number."); 
            }
        }
    }
}
