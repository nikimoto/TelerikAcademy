using System;
using System.Collections.Generic;


class KElementsWithMaxSum
{
    static void Main()
    {
        //int[] array = { 12, 7, 12, 8, 11, 9, 7, 8, 9 };
        //int k=4;

        Console.Write("Enter the array's size: N = ");
        int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];
        int k;
        int sum=0;
        int bestSum = int.MinValue;
        string bestSeq = "";

        do
        {
            Console.WriteLine("Enter number K < N ");
            k = int.Parse(Console.ReadLine());
        }
        while (k > array.Length);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length; i++)
        {
            string sequence = "";
            if (k + i > array.Length)
            {
                break;
            }
            for (int j = i; j < k+i; j++)
            {
                sum += array[j];
                sequence = sequence + array[j] + " ";
            }
            if (sum > bestSum)
            {
                bestSum = sum;
                bestSeq = sequence;
            }
            sum = 0;
        }
        Console.WriteLine("\nThe array is:");
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
        Console.WriteLine("The best sum is: {0}",bestSum);
        Console.WriteLine("The best sequence of elements is: {0}",bestSeq);
    }
}
