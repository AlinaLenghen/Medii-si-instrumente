using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input the number of elements to be stored in the array:");
        int n = int.Parse(Console.ReadLine()!);

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"element - {i} : ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int sum = CalculateSum(array);

        Console.WriteLine($"Sum of all elements stored in the array is : {sum}");
    }

    static int CalculateSum(int[] arr)
    {
        int sum = 0;

        foreach (int element in arr)
        {
            sum += element;
        }

        return sum;
    }
}
