using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        displayWelcome();

        string name = GetName();

        int favoriteNumber = GetFavNumber();

        int square = SquareNumber(favoriteNumber);

        Console.WriteLine($"Hello, {name}! The square of your favorite number is {square}.");
    }

    static void displayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string GetName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int GetFavNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }
}
