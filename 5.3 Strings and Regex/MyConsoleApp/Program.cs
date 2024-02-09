using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine(DecimalDigitInformation("This is 9"));    
        Console.WriteLine(DecimalDigitInformation("ABCdef"));      
    }

    static string DecimalDigitInformation(string input)
    {
        Match match = Regex.Match(input, @"\d");

        if (match.Success)
        {
            char digit = match.Value[0];
            int position = match.Index; 

            return $"Digit {digit} at position {position}";
        }

        return "No digit found!";
    }
}
