using System;

public class Program
{
    static void Main()
    {
        int aInt = 2, bInt = 3;
        Console.WriteLine($"Before swap: a={aInt}; b={bInt}");
        Swap(ref aInt, ref bInt);
        Console.WriteLine($"After swap: a={aInt}; b={bInt}");

        string aStr = "abc", bStr = "def";
        Console.WriteLine($"Before swap: a={aStr}; b={bStr}");
        Swap(ref aStr, ref bStr);
        Console.WriteLine($"After swap: a={aStr}; b={bStr}");
    }

    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
