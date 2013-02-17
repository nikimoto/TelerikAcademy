using System;
using System.Collections.Generic;


class BinarySearch
{
    static void Main()
    {
        //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 60, 33, 23, 21, 65, 765 };        
        //int searched = 33;
        
        Console.Write("Enter the array's size: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        Console.WriteLine("Enter the array's elements: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write("array[{0}]:", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the searced number: ");
        int searched = int.Parse(Console.ReadLine());
        int min, max;

        Array.Sort(array);
        min = 0;
        max = array.Length-1;

        while (min <= max)
        {
            int middle = (min + max) / 2;
            if (array[middle] < searched)
            {
                min = middle + 1;
            }
            else if (array[middle] > searched)
            {
                max = middle - 1;
            }
            else 
            {
                Console.WriteLine("Sorted array:");
                foreach (int num in array)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
                Console.WriteLine("The index of searched number in the array is: array[{0}] ", middle);
                Console.WriteLine("The searced number is: {0}", array[middle]);
                break;
            }
        }
        

    }
}
