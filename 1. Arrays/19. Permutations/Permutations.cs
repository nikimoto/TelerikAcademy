using System;
using System.Collections.Generic;
using System.Linq;


class Permutations
{
    static int counter = 0;

    static void Swap(ref int first, ref int second)
    {
        int temp = first;
        first = second;
        second = temp;        
    }

    static void Permutatation(int[] array, int current, int length)
    {           
        if (current == length)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            counter++;
        }
        else
        {
            for (int i = current; i <= length; i++)
            {
                Swap(ref array[i], ref array[current]);
                Permutatation(array, current + 1, length);
                Swap(ref array[i], ref array[current]);
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter a number N: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];       

        for (int i = 0; i < n; i++)
        {
            array[i] = i + 1;
        }

        Permutatation(array, 0, array.Length-1);
        Console.WriteLine("All permutations are {0}", counter);
    }
}
