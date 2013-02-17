using System;
using System.Collections.Generic;


class CombinationsK
{
    static int N = int.Parse(Console.ReadLine());
    static int K = int.Parse(Console.ReadLine());
    static int counter = 0;

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        counter++;
    }
        
    static void Combinations(int[] array, int index, int currentNumber)
    {
        if (index == array.Length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = currentNumber; i <= N; i++)
            {
                array[index] = i;
                Combinations(array, index + 1, i + 1);
            }
        }
    }

    static void Main()
    {
        int[] array = new int[K];
        Combinations(array, 0, 1);
        Console.WriteLine("All combinations are {0}", counter);
    }    
}

