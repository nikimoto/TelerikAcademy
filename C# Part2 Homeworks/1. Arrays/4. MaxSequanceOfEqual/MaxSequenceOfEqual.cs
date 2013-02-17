using System;
using System.Collections.Generic;


class MaxSequenceOfEqual
{
    static void Main()
    {
       // int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

        Console.Write("Enter the array's size:");
        int number = int.Parse(Console.ReadLine());
        int[] array = new int[number];
        int start = 0;
        int len = 1;
        int bestLen = 1;
        int bestStart = 0;

        Console.WriteLine("Enter the array's values: ");
        for (int i = 0; i < number; i++)
        {
            Console.Write("array [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] == array[i + 1])
            {
                len++;

                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = start;
                }
            }
            else
            {
                len = 1;
                start = i + 1;
            }           
        }

        Console.Write("\nThe array is: ");
        foreach (int element in array)
        {
            Console.Write(element + " ");   
        }        
        Console.Write("\nBest sequence: ");
        for (int i = bestStart; i < bestStart + bestLen; i++)
        {            
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}