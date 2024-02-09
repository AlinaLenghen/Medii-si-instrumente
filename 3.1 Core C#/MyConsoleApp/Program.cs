using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine()!;

        int alphabetCount = 0;
        int digitCount = 0;
        int specialCharCount = 0;

        foreach (char ch in input!)
        {
            if (char.IsLetter(ch))
            {
                alphabetCount++;
            }
            else if (char.IsDigit(ch))
            {
                digitCount++;
            }
            else
            {
                specialCharCount++;
            }
        }

        Console.WriteLine($"Number of Alphabets in the string is: {alphabetCount}");
        Console.WriteLine($"Number of Digits in the string is: {digitCount}");
        Console.WriteLine($"Number of Special characters in the string is: {specialCharCount}");
    }
}
