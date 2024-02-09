using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first integer:");
        int num1 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter the second integer:");
        int num2 = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Numbers before interchange: num1 = {num1}, num2 = {num2}");

        // Swap the numbers using a temporary variable
        int temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine($"Numbers after interchange: num1 = {num1}, num2 = {num2}");
    }
}