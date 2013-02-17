using System;
using System.Collections.Generic;


class FillingMatrix
{  
    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    private static void MatrixTypeA(int n)
    {
        int[,] matrix = new int[n, n];
        for (int row = 0, counter = 1; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrix[col, row] = counter;
                counter++;
            }
        }
        Console.WriteLine("Matrix of type A:");
        Console.WriteLine();
        PrintMatrix(matrix);
    }

    private static void MatrixTypeB(int n)
    {
        int[,] matrix = new int[n, n];
        for (int row = 0, counter = 1; row < n; row++)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix[col, row] = counter;
                    counter++;
                }
            }
            else
            {
                for (int col = n - 1; col >= 0; col--)
                {
                    matrix[col, row] = counter++;
                }
            }
        }
        Console.WriteLine("Matrix of type B:");
        Console.WriteLine();
        PrintMatrix(matrix);
    }

    private static void MatrixTypeC(int n)
    {
        int[,] matrix = new int[n, n];
        int counter = 1;

        for (int row = 0; row <= n - 1; row++)
        {
            for (int col = 0; col <= row; col++)
            {
                matrix[n - row + col - 1, col] = counter;
                counter++;
            }
        }

        for (int row = n - 2; row >= 0; row--)
        {
            for (int col = row; col >= 0; col--)
            {
                matrix[row - col, n - col - 1] = counter;
                counter++;
            }
        }

        Console.WriteLine("Matrix of type C:");
        Console.WriteLine();
        PrintMatrix(matrix);
    }

    private static void MatrixTypeD(int n)
    {
        int[,] matrix = new int[n, n];
        int end = n;
        int start = 0;
        int counter = 1;
        do
        {
            for (int i = start; i < end; i++)
            {
                matrix[i, start] = counter;
                counter++;
            }
            for (int j = start + 1; j < end; j++)
            {
                matrix[end - 1, j] = counter;
                counter++;
            }
            for (int p = end - 2; p >= start; p--)
            {
                matrix[p, end - 1] = counter;
                counter++;
            }
            for (int q = end - 2; q >= start + 1; q--)
            {
                matrix[start, q] = counter;
                counter++;
            }
            start++;
            end--;
        }
        while (end - start > 0);

        Console.WriteLine("Matrix of type D:");
        Console.WriteLine();
        PrintMatrix(matrix);
    }

    static void Main()
    {
        Console.Write("Enter matrix's size: ");
        int n = int.Parse(Console.ReadLine());

        MatrixTypeA(n);
        MatrixTypeB(n);        
        MatrixTypeC(n);
        MatrixTypeD(n);
    }

    

    

    
    
}
