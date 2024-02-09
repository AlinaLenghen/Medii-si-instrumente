using System;
using System.Collections.Generic;

class Problem2
{
    static void Main()
    {
        Console.WriteLine("Problem 2: Read Numbers until Two Consecutive Zeros");
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Enter a number (enter 00 to stop): ");
            int currentNumber = int.Parse(Console.ReadLine()!);

            if (currentNumber == 0)
            {
                if (numbers.Count > 0 && numbers[numbers.Count - 1] == 0)
                {
                    break; 
                }
            }

            numbers.Add(currentNumber);
        }

        Console.WriteLine("Entered Numbers:");
        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
        }
    }
}