using System;

class Problem1
{
    static void Main()
    {
        Console.WriteLine("Problem 1: Sum of Two Numbers");

        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine()!;

        Console.Write("Enter the second number: ");
        string input2 = Console.ReadLine()!;

        // Check for null before parsing
        if (input1 != null && input2 != null)
        {
            if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2))
            {
                int sum = num1 + num2;
                Console.WriteLine($"Sum: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
        }
        else
        {
            Console.WriteLine("Input cannot be null.");
        }
    }
}