using System;
using System.Collections.Generic;


class LargestAreaOfEqualElements
{
    public static int maxLength = 0;
    public static int currentLength = 0;

    static bool IsValidCell(string[,] matrix, int x, int y)
    {
        return x >= 0 && matrix.GetLength(0) > x && y >= 0 && matrix.GetLength(1) > y;
    }

    public static void SearchArea(string[,] matrix, int row, int col)
    {
        string cellValue = matrix[row, col];
        matrix[row, col] = "*";
        currentLength++;
        for (int add = -1; add <= 1 ; add += 2)
        {
            if (IsValidCell(matrix, row + add, col) && matrix[row + add, col] == cellValue)
            {
                SearchArea(matrix, row + add, col);
            }
            if (IsValidCell(matrix, row, col + add) && matrix[row, col + add] == cellValue)
            {
                SearchArea(matrix, row, col + add);
            }
        }
    }

    public static void PrintMatrix(string[,] matrix)
    {
        int max = 0;
        foreach (var item in matrix)
        {
            if (item.Length > max)
            {
                max = item.Length;
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", 
                    matrix[row, col].PadLeft(matrix[row, col].Length + (max - matrix[row, col].Length) / 2).PadRight(max));
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Enter the matrix rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the matrix columns: ");
        int cols = int.Parse(Console.ReadLine());

        string[,] matrix = new string[rows, cols];

        Console.WriteLine("Enter the cells of the matrix:\n");
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }
        
        Console.WriteLine();
        PrintMatrix(matrix);
        Console.WriteLine();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] != "*")
                {
                    currentLength = 0;
                    SearchArea(matrix, row, col);
                    PrintMatrix(matrix);
                    Console.WriteLine("Current area = {0}\n\n", currentLength);
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                }
            }
        }
        Console.WriteLine("Largest area = {0}", maxLength);
    }
}
