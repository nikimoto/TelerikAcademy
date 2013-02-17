using System;
using System.Collections.Generic;


class MergeSortAlgorithm
{
    static int[] MergeSort (int[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }

        int middle = array.Length / 2;
        int[] left = new int[middle];
        int[] right = new int[array.Length - middle];

        for (int i = 0; i < middle; i++)
        {
            left[i] = array[i];
        }   

        for (int i = middle, j = 0; i < array.Length; i++, j++)
        {
            right[j] = array[i];
        }
        left = MergeSort(left);
        right = MergeSort(right);

        return Merge(left, right);
    }
    static int[] Merge(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];
        int leftLen = 0;
        int rightLen = 0;

        for (int i = 0; i < result.Length; i++)
        {
            if (rightLen == right.Length || (leftLen < left.Length) && (left[leftLen] <= right[rightLen]))
            {
                result[i] = left[leftLen];
                leftLen++;
            }
            else if (leftLen == left.Length || (rightLen < right.Length) && (right[rightLen] <= left[leftLen]))
            {
                result[i] = right[rightLen];
                rightLen++;
            }
        }
        return result;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");            
        }
        Console.WriteLine();
    }
    static void Print(string str)
    {
        Console.WriteLine(str);
    }

    static void Main(string[] args)
    {
        int[] arrayToSort = { 1, 5, 7, 8, 9, 3, 5, 6, 7};
        Print("The original array:");
        PrintArray(arrayToSort);
        int[] sortedArray = MergeSort(arrayToSort);
        Print("The sorted array:");
        PrintArray(sortedArray);
    }
}
