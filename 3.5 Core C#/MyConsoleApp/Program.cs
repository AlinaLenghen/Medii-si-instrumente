using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(IfNumberContains3(7201432)); 
        Console.WriteLine(IfNumberContains3(87501));    
    }

    static bool IfNumberContains3(int number)
    {
      
        while (number > 0)
        {
            int digit = number % 10;  
            if (digit == 3)
            {
                return true;  
            }

            number /= 10;
        }

        return false; 
    }
}
