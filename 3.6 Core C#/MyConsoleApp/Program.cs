using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(ToThePowerOf(2, 3));  
        Console.WriteLine(ToThePowerOf(5, 5));  
    }

    static int ToThePowerOf(int baseNumber, int exponent)
    {
        if (exponent < 0)
        {
            Console.WriteLine("Exponent should be a non-negative integer.");
            return -1;  
        }

        int result = 1;

        for (int i = 0; i < exponent; i++)
        {
            result *= baseNumber;
        }

        return result;
    }
}
