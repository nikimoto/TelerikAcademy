using System;
using System.Collections.Generic;


class CountNumberInArray
{
    static int WantedNumber(int[] arr, int wanted)
    {
        int counter = 0;
        foreach (int item in arr)
        {
            if (item == wanted)
            {
                counter++;
            }
        }
        return counter;
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
        Console.Write("Enter wanted number:");
        int wanted = int.Parse(Console.ReadLine());
        
        Console.WriteLine("The wanted number appears {0} times", WantedNumber(array, wanted));
    }
}
