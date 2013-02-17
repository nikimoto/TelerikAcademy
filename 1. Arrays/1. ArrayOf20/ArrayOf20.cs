using System;
using System.Collections.Generic;


class ArrayOf20
{
    static void Main()
    {
        int[] array = new int[20];

        for (int index = 0; index < array.Length; index++)
        {
            array[index] += index * 5; 
        }
        foreach (int number in array)
        {
            Console.Write(number + " ");            
        }
    }
}
