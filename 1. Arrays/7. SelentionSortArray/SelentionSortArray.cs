using System;
using System.Collections.Generic;



class SelentionSortArray
{
    static void Main()
    {
        //int[] array = { 4, 5, 61, 2, 34, 4, 5, -16, 0, -9, -10, 11, 14, -5465 };

        Console.Write("Enter the array's size: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        int temp = 0;        

        for (int i = 0; i < size; i++)
        {
            Console.Write("array[{0}]:", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nThe original unsorted array is: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write(array[i] + " ");
        }

        for (int i = 0; i < array.Length-1; i++)
        {
            int min = i;
            for (int j = i; j < array.Length; j++)
            {
                if (array[min] > array[j])
                {
                    min = j;
                }
            }
            if (min != i)
            {
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
        }
        
        Console.WriteLine("\nThe array after sorting is:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine(); 

        //Array.Sort(array);

        //Console.Write("Sortet array is: ");
        //foreach (int element in array)
        //{
        //    Console.Write(element + " ");
        //}
        //Console.WriteLine();
        
    }
}
