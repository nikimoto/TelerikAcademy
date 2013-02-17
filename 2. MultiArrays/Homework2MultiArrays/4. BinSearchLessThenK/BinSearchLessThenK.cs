using System;
using System.Collections.Generic;

class BinSearchLessThenK
{
    static void Main()
    {
        Console.Write("Enter the array's size: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];        

        Console.WriteLine("Enter the cells of the array: ");        
        for (int i = 0; i < size; i++)
        {
            Console.Write("array[{0}] = ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }        
        Console.Write("Enter number K = ");
        int k = int.Parse(Console.ReadLine());

        Array.Sort(array);
        int result;

        if (array[0] > k)
        {
            Console.WriteLine("There is no number in the array, that is less or equal to K!");
        }
        else
        {
            int index = Array.BinarySearch(array, k);
            if (index >= 0)
            {
                result = array[index];
            }
            else
            {
                result = array[~index - 1];
            }
            Console.WriteLine(result);
        }
    }
}
