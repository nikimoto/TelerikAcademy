using System;
using System.Collections.Generic;


class MaxElementAtGivenIndex
{
    static int[] FillArray(int[] arr, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element[{0}]", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        return arr;
    }

    static int MaxElementAtIndex(int[] arr, int index)
    {
        //int size = arr.Length;       
        int max = arr[index];
        for (int i = index; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (max < arr[j])
                {
                    max = arr[j];
                }
            }
        }
        return max;
    }

    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static int GetBestPosition(int[] arr, int i, int choise)
    {
        int best = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            switch (choise)
            {
                case 1:
                    if (arr[best] > arr[j])
                    {
                        best = j;
                    }
                    break;
                case 2:
                    if (arr[j] > arr[best])
                    {
                        best = j;
                    }
                    break;
                default: Console.WriteLine("Invalid Choise!");
                    break;
            }
        }
        return best;
    }

    static void SelectionSort(int[] arr, int choise)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Swap(arr, i, GetBestPosition(arr, i, choise));
        }
    }

    static void PrintResult(int[] result)
    {
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter array's size:");
        int size = int.Parse(Console.ReadLine());
        int[] array1 = new int[size];

        Console.WriteLine("Enter elements of array:");
        array1 = FillArray(array1, size);
        Console.Write("Enter start index: ");
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine("The maximal elements is {0}", MaxElementAtIndex(array1, index));

        Console.Write("Choose Ascending (1) or Descending (2) order to sort array: ");
        int choise = int.Parse(Console.ReadLine());

        SelectionSort(array1, choise);
        PrintResult(array1);        
    }
}
