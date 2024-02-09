using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Temperature temp1 = new Temperature(25);
            temp1.DisplayTemperature();

            Temperature temp2 = new Temperature(0);
            temp2.DisplayTemperature();
        }
        catch (TempIsZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}