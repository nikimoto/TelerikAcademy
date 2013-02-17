using System;
using System.Collections.Generic;

class ElementsAndTwoNeighbors
{

    static void CheckNeighbors(int[] arr, int index)
    {
        if (index >= arr.Length || index < 0)
        {
            Console.WriteLine("Invalid index");            
        }
        if (index == 0)
        {
            Console.WriteLine("One Right neighbor");
            ChekRight(arr, index);
        }
        if (index == arr.Length - 1)
        {
            Console.WriteLine("One Left neighbor");
            ChekLeft(arr, index);
        }
        else if (index > 0 && index < arr.Length)
        {
            Console.WriteLine("Two neighbor");
            ChekRight(arr, index);
            ChekLeft(arr, index);
        }
    }

    static void ChekRight(int[] arr, int index)
    {
        if (arr[index] > arr[index+1])
            Console.WriteLine("The element {0} with index {1} is bigger than his right neighbor ({2})",arr[index], index, arr[index+1]);
        else if (arr[index] < arr[index + 1])
            Console.WriteLine("The element {0} with index {1} is saller than his right neighbor ({2})", arr[index], index, arr[index + 1]);
        else
        {
            Console.WriteLine("The element {0} with index {1} is equal to his right neighbor ({2})", arr[index], index, arr[index + 1]);
        }
    }

    static void ChekLeft(int[] arr, int index)
    {
        if (arr[index] > arr[index - 1])
            Console.WriteLine("The element {0} with index {1} is bigger than his left neighbor ({2})", arr[index], index, arr[index - 1]);
        else if (arr[index] < arr[index - 1])
            Console.WriteLine("The element {0} with index {1} is saller than his left neighbor ({2})", arr[index], index, arr[index - 1]);
        else
        {
            Console.WriteLine("The element {0} with index {1} is equal to his left neighbor ({2})", arr[index], index, arr[index - 1]);
        }
    }

    private static void PrintMatrix(int[] arr)
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

        Console.Write("Enter the index: ");
        int index = int.Parse(Console.ReadLine());
        CheckNeighbors(array, index);   
    }
}
