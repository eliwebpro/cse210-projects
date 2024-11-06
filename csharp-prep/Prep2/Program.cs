using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int numberGrade = int.Parse(grade);
        string letter = "";

        if (numberGrade >= 90)
        {
            letter = "A";
        }
        else if (numberGrade >= 80)
        {
            letter = "B";
        } 
        else if (numberGrade >= 70)
        {
            letter = "C";
        } 
        else if (numberGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (numberGrade >= 60)
        {
            Console.WriteLine($"Congrats, you passed! Your grade is {letter}");
        }
        else
        {
            Console.WriteLine($"You did not pass, your grade is {letter}");
        }
    }
}
