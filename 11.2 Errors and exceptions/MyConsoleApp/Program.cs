using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 10, 20, 30, 40, 50 }; 

        while (true)
        {
            try
            {
                Console.Write("Enter the index of the element you want to see (or 'q' to quit): ");
                string input = Console.ReadLine()!;

                if (input.ToLower() == "q")
                {
                    Console.WriteLine("Exiting the program...");
                    break;
                }

                int index = int.Parse(input);

                if (index < 0 || index >= array.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range. Please enter a valid index.");
                }

                Console.WriteLine($"Element at index {index}: {array[index]}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter a valid integer index.");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
