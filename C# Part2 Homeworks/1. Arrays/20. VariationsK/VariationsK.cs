using System;
using System.Collections.Generic;


class VariationsK
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

    static void Variant(int[] array, int index)
    {
        if (index == array.Length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = 0; i < N; i++)
            {
                array[index] = i + 1;
                Variant(array, index + 1);
            }
        }
    }

    static void Main()
    {
        int[] variants = new int[K];
        Variant(variants, 0);
        Console.WriteLine("Number of all variants: {0}", counter);
    }
}
