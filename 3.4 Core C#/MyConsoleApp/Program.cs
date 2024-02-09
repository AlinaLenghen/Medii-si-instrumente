using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double num1 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter the second number:");
        double num2 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter the operation (+, -, *, /):");
        char operation = char.Parse(Console.ReadLine()!);

        double result = CalculateOperation(num1, num2, operation);

        if (result != double.MinValue)
        {
            Console.WriteLine($"Result: {result}");
        }
        else
        {
            Console.WriteLine("Unrecognized character");
        }
    }

    static double CalculateOperation(double num1, double num2, char operation)
    {
        switch (operation)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                // Check for division by zero
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return double.MinValue;
                }
            default:
                return double.MinValue;
        }
    }
}
