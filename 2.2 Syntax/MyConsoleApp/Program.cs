using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the coefficient a (a != 0):");
        double a = double.Parse(Console.ReadLine()!);

        if (a == 0)
        {
            Console.WriteLine("Coefficient 'a' cannot be zero. Please enter a non-zero value.");
            return;
        }

        Console.WriteLine("Enter the coefficient b:");
        double b = double.Parse(Console.ReadLine()!);

        // Solve the first-degree equation
        double x = -b / a;

        Console.WriteLine($"Solution for x: {x}");
    }
}