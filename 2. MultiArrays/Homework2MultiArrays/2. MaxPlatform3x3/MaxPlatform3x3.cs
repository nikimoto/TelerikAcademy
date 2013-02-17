using System;
using System.Collections.Generic;



class MaxPlatform3x3
{
    static int PlatformSum(int[,] matrix, int k, int row, int col)
    {
        int sum = 0;
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < k; j++)
            {
                sum = sum + matrix[row + i, col + j];
            }
        }
        return sum;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,5}", matrix[row, col]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    private static void PrintBestPlatform(int[,] matrix, int bestSum, int bestRow, int bestCol)
    {
        Console.WriteLine("The best platform is: \n");
        Console.WriteLine("  {0} {1,5} {2,5}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
        Console.WriteLine("  {0} {1,5} {2,5}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine("  {0} {1,5} {2,5} \n", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
        Console.WriteLine("The maximal sum is: {0}", bestSum);
    }

    static void Main()
    {
        //int[,] matrix = { { 1, 2, 3, 4 }, { 10, 20, 30, 40 }, { 100, 200, 300, 400 }, { 1000, 2000, 3000, 4000 } }; 
        Console.WriteLine("Enter the matrix's dimensions (N x M -> N and M must be >=3 ): ");
        int n, m;
        do
        {
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());

            Console.Write("M = ");
            m = int.Parse(Console.ReadLine());
        }
        while (n < 3 || m < 3);

        int[,] matrix = new int[n, m];
        int k = 3; // Square size

        Console.WriteLine("Enter the cells of the matrix:");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("matrix[{0},{1}] = ",row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();

        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row <= matrix.GetLength(0) - k; row++)
        {
            for (int col = 0; col <= matrix.GetLength(1) - k; col++)
            {
                int sum = PlatformSum(matrix, k, row, col);

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            } 
        }
        PrintMatrix(matrix);
        Console.WriteLine();
        PrintBestPlatform(matrix, bestSum, bestRow, bestCol);


    }

   
}
