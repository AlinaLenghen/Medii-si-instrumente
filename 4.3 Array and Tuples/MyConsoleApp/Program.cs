using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input the size of the square matrix (less than 5):");
        int size = int.Parse(Console.ReadLine()!);

        int[,] matrix1 = InputMatrix(size, "first");

        int[,] matrix2 = InputMatrix(size, "second");

        Console.WriteLine("The First matrix is:");
        DisplayMatrix(matrix1);

        Console.WriteLine("The Second matrix is:");
        DisplayMatrix(matrix2);

        int[,] resultMatrix = AddMatrices(matrix1, matrix2);

        Console.WriteLine("The Addition of two matrices is:");
        DisplayMatrix(resultMatrix);
    }

    static int[,] InputMatrix(int size, string matrixName)
    {
        Console.WriteLine($"Input elements in the {matrixName} matrix :");
        int[,] matrix = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"element - [{i}],[{j}] : ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        return matrix;
    }

    static void DisplayMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int size = matrix1.GetLength(0);
        int[,] resultMatrix = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return resultMatrix;
    }
}
