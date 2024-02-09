using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number:");
        int decimalNumber = int.Parse(Console.ReadLine()!);

        string binaryRepresentation = ConvertDecimalToBinary(decimalNumber);

        Console.WriteLine($"Binary: {binaryRepresentation}");
    }

    static string ConvertDecimalToBinary(int decimalNumber)
    {
        string binaryRepresentation = Convert.ToString(decimalNumber, 2);
        return binaryRepresentation;
    }
}
