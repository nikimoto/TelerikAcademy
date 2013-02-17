using System;
using System.Collections.Generic;


class BiggestThanNeighbors
{
    static int IndexOfBigger(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (CheckNeighbors(arr, i) == 1)
            {
                return i;
            }            
        }
        return -1;
    }

    static int CheckNeighbors(int[] arr, int index)
    {
        if (ChekLeft(arr, index) && ChekRight(arr, index))
        {
            return 1;
        }
        return -1;
    }

    static bool ChekRight(int[] arr, int index)
    {
        if (index == arr.Length - 1)
            return false;
        if (arr[index] > arr[index + 1])
            return true;
        else
            return false;
    }

    static bool ChekLeft(int[] arr, int index)
    {
        if (index == 0)
            return false;
        if (arr[index] > arr[index - 1])
            return true;
        else
            return false;
    }

    static void PrintMatrix(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0} ", arr[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter the size of the array:");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        Console.WriteLine("Enter the array's elements:");
        for (int i = 0; i < size; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        PrintMatrix(array);
        //Console.Write("Enter the index: ");
        //int index = int.Parse(Console.ReadLine());

        Console.WriteLine("Index of first element, bigger than his neighbor is {0}",IndexOfBigger(array));
    }
}
