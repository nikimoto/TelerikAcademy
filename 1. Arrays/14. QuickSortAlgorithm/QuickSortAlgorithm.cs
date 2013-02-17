using System;
using System.Collections.Generic;
using System.Linq;

class QuickSortAlgorithm
{
    static List<int> QuickSort(List<int> array)
    {
        if (array.Count <= 1)
        {
            return array;
        }

        int pivot = (array[array.Count/2]);
        List<int> left = new List<int>();
        List<int> right = new List<int>();

        for (int i = 0; i < array.Count; i++)
        {
            if (i!= array.Count/2)
            {
                if (array[i] <= pivot)
                {
                    left.Add(array[i]);
                }
                else
                {
                    right.Add(array[i]);
                }
            }
        }

        return Concatenate(QuickSort(left), pivot, QuickSort(right));
    }

    static List<int> Concatenate( List<int> left, int pivot, List<int> right)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < left.Count; i++)
        {
            result.Add(left[i]);
        }

        result.Add(pivot);

        for (int i = 0; i < right.Count; i++)
        {
            result.Add(right[i]);
        }

        return result;
    }

    static void Print(List<int> array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");            
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //string[] stringArray = { "ada", "dsds", "erwer", "ftrete", "test", "aa", "da", "db", "ad", "fa", "faa", "ada" };
        //List<string> sortedList = stringArray.ToList();
        List<int> array = new List<int>() { 1, 6, 33, 6, 8, 44, 9, 23, 2, 21, 64, 26, 3 };

        Console.WriteLine("The original array is: ");
        Print(array);
        List<int> sortedArray = QuickSort(array);
        Console.WriteLine("The sorted array is: ");
        Print(sortedArray);        
    }
}
