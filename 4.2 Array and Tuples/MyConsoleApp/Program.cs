using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input the number of elements to be stored in the array:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"element - {i} : ");
            array[i] = int.Parse(Console.ReadLine()!);
        }

        int[] evenArray, oddArray;
        SeparateOddEven(array, out evenArray, out oddArray);

        Console.WriteLine("The Even elements are:");
        DisplayArray(evenArray);

        Console.WriteLine("The Odd elements are:");
        DisplayArray(oddArray);
    }

    static void SeparateOddEven(int[] inputArray, out int[] evenArray, out int[] oddArray)
    {
        int evenCount = 0, oddCount = 0;

        foreach (int element in inputArray)
        {
            if (element % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }

        evenArray = new int[evenCount];
        oddArray = new int[oddCount];

        int evenIndex = 0, oddIndex = 0;
        foreach (int element in inputArray)
        {
            if (element % 2 == 0)
            {
                evenArray[evenIndex++] = element;
            }
            else
            {
                oddArray[oddIndex++] = element;
            }
        }
    }

    static void DisplayArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
