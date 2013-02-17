using System;
using System.Collections.Generic;


class SequenceOfMaxSum
{
    static void Main()
    {
        //int[] array = {2, 3, -6, -1, 2, -1, 6, 4, -8, 8};

        Console.Write("Enter the array's size: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        int maxSum = int.MinValue;
        int sum = 0;
        int start = 0;
        int bestStart = 0;
        int len = 0;

        for (int i = 0; i < size; i++)
        {
            Console.Write("array[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }        

        Console.Write("\nThe array is: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write(array[i] + " ");
        }

        for (int i = 0; i < size; i++)
        {
            sum += array[i];
            if (sum > maxSum)
            {
                maxSum = sum;
                len = i;
            }
            else if (sum < 0)
            {
                sum = 0;
                bestStart = start;
                start = i + 1;                
            }
        }        
        Console.Write("\nMaximal sum is: {0}", maxSum);
        Console.Write("\nThe sequence with max sum is: ");
        for (int i = bestStart; i <= len; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
