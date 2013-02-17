using System;
using System.Collections.Generic;
using System.Linq;


class SubsetSumWithKLength
{
    static void Main()
    {
        Console.Write("Enter the array's size: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        Console.Write("Enter the length of the subset: ");
        int subsetLen = int.Parse(Console.ReadLine());

        Console.Write("Enter the wanted sum: ");
        int wantedSum = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the array's elements: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write("array[{0}]:", i);
            array[i] = int.Parse(Console.ReadLine());
        }        

        int counter = 0;
        string subset = "";
        int maxSubsets = (int)Math.Pow(2, size) - 1;

        for (int i = 1; i <= maxSubsets; i++)
        {
            int sum = 0;
            subset = "";
            int lenCounter = 0;

            for (int j = 0; j <= size; j++)
            {
                int mask = 1 << j;
                int iAndMask = i & mask;
                int bit = iAndMask >> j;
                if (bit == 1)
                {
                    sum += array[j];
                    subset += array[j] + " ";
                    lenCounter++;
                }
            }

            if (sum == wantedSum && lenCounter == subsetLen)
            {
                Console.WriteLine("The subset with wanted sum {0} is: {1} ", wantedSum, subset);
                counter++;
            }
        }
        if (counter != 0)
        {
            Console.WriteLine("The sum of subsets with wanted sum and length = {0}", counter);
            
        }
        else
        {
            Console.WriteLine("There is no subset with wanted sum and length");
        }
    }
}
