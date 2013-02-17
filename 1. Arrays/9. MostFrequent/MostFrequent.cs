using System;
using System.Collections.Generic;


class MostFrequent
{
    static void Main()
    {
        //int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        //int[] array = { 1, 1, 2, 3, 4, 5, 1, 2, 2 };

        Console.Write("Enter the array's size: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        int counter = 1;
        int bestCounter = 0;
        int mostFrequent = int.MinValue;
        List<int> supportArray = new List<int>();
        int support = 0;

        for (int i = 0; i < size; i++)
        {
            Console.Write("array[{0}]:", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nThe array is: ");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();

        Array.Sort(array);

        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] == array[i + 1])
            {
                counter++;
            }
            else 
            {
                counter = 1;
            }
            if (counter > bestCounter)
            {
                bestCounter = counter;
                mostFrequent = array[i];
            }
            else if (counter == bestCounter)
            {
                supportArray.Add(array[i]);
                support = counter;
            }
        }

        if (bestCounter > 1)
        {
            Console.Write("Most frequent element is: {0}", mostFrequent);
            Console.WriteLine("-> ({0} times)", bestCounter);
        }
        else if (support > 1)
        {            
            
            Console.Write("Most frequent elements are: {0} ", mostFrequent);
            foreach (int item in supportArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("-> ({0} times)", support);
        }
        else 
        {            
            Console.WriteLine("All elements in the array are different");
        }
    }
}
