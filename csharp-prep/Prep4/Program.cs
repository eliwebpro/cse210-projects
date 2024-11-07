using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        // list
        List<int> numbers = new List<int>();
        
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when you finished. ");
            
            string response = Console.ReadLine();
            userNumber = int.Parse(response);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        // total
        int sumTotal = 0;
        foreach (int number in numbers)
        {
            sumTotal += number;
        }

        Console.WriteLine($"The sum is: {sumTotal}");

        // avarege
        float average = ((float)sumTotal) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // max
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}