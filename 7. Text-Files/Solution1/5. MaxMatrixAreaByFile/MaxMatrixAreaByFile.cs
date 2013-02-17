using System;
using System.IO;


class MaxMatrixAreaByFile
{
    static int[,] matrix;

    private static void ReadFile(string fileName)
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line = reader.ReadLine();
            int size = int.Parse(line);
            matrix = new int[size, size];
            int row = 0;
            line = reader.ReadLine();
            while (line != null)
            {
                FillRow(row, line);
                row++;
                line = reader.ReadLine();
            }
        }
    }

    private static void WriteToFile(int sum, string newFileName)
    {
        using (StreamWriter writer = new StreamWriter(newFileName))
        {
            writer.WriteLine("The maximal sum is: {0}", sum);
        }
    }

    private static void FillRow(int row, string line)
    {
        char[] charSeparator = { ' ', ',' };
        string[] sequence = line.Split(charSeparator, StringSplitOptions.RemoveEmptyEntries);
        int length = sequence.Length;

        for (int i = 0; i < length; i++)
        {
            matrix[row, i] = int.Parse(sequence[i]); 
        }
    }

    private static int CheckMaxSum(int[,] matrix, int rowsNumber, int colsNumber)
    {
        int bestSum = int.MinValue;       

        for (int row = 0; row < rowsNumber - 1; row++)
        {
            for (int col = 0; col < colsNumber - 1; col++)
            {                
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                if (sum > bestSum)
                {
                    bestSum = sum;                    
                }
            }
        }

        Console.WriteLine("The maximum sum is: {0}", bestSum);
        Console.WriteLine("Chek your output file.");

        return bestSum;
    }

    static void Main()
    {
        string firstFileName = "../../matrix.txt";
        string newFileName = "../../result.txt";

        ReadFile(firstFileName);

        int maxSum = CheckMaxSum(matrix, matrix.GetLength(0) - 1, matrix.GetLength(1) - 1);

        WriteToFile(maxSum, newFileName);        
    }
}
