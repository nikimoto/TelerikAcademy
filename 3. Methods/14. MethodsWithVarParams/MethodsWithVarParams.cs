using System;
using System.Collections.Generic;


class Methods
{
    static int MinValue(params int[] arr)
    {
        int min = int.MaxValue;
        foreach (int item in arr)
        {
            if (item < min)
            {
                min = item;
            }
        }
        return min;
    }

    static int MaxValue(params int[] arr)
    {

        int max = int.MinValue;
        foreach (int item in arr)
        {
            if (item > max)
            {
                max = item;
            }
        }
        return max;
    }

    static decimal AverageValue(params int[] arr)
    {
        decimal result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
        }
        return result / arr.Length;
    }

    static long Sum(params int[] arr)
    {
        long sum = 0;
        foreach (int item in arr)
        {
            sum += item;
        }
        return sum;
    }

    static long Product(params int[] arr)
    {
        long product = 1;
        foreach (int item in arr)
        {
            product *= item;
        }        
        return product;
    }

    static void Main()
    {
        Console.Write("Enter how many numbers you want to manipulate: ");
        int numbers = int.Parse(Console.ReadLine());
        int[] arr = new int[numbers]; //{ 2, 3, 5, 123, 1, 2, 3, 51, 213 };

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("The minimum is: {0}", MinValue(arr));
        Console.WriteLine("The maxmimum is: {0}", MaxValue(arr));
        Console.WriteLine("The average number is: {0}", AverageValue(arr));
        Console.WriteLine("The sum is: {0}", Sum(arr));
        Console.WriteLine("The product is: {0}", Product(arr));
    }

   
}
