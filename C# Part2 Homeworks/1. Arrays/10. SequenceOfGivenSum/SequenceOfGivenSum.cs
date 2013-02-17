using System;
using System.Collections.Generic;



class SequenceOfGivenSum
{
    static void Main()
    {
        //int[] array = {4, 2, 5, 11, 8, 3, 4, 3, 1, }; // s=11 -> {4, 2, 5}
        //int sum = 11;

        Console.Write("Enter the array's size: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        Console.Write("Enter the sum S: ");
        int sum = int.Parse(Console.ReadLine());
        int currentSum = 0;
        int start = 0;
        int end = 0;
        int numOfSums = 0;
        bool isFoundSum = false;

        Console.WriteLine("Please enter the elements of the array");
        for (int i = 0; i < size; i++)
        {
            Console.Write("array[{0}]:", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length-1; i++)
        {            
            currentSum += array[i];
            if (currentSum == sum)
            {
                Console.WriteLine("The elements with sum {0} are: {1} ", sum, array[i]);
                isFoundSum = true;
                numOfSums++;
                currentSum = 0;
                continue;
            }

            for (int j = i + 1; j < array.Length; j++)
            {
                currentSum += array[j];
                if (currentSum == sum)
                {
                    isFoundSum = true;
                    start = i;
                    end = j;
                    numOfSums++;
                    Console.Write("The elements with sum {0} are: ", sum);

                    for (int k = start; k <= end; k++)
                    {
                        Console.Write(array[k] + " ");
                    }
                    Console.WriteLine();                    
                }                
            }
            currentSum = 0;
        }
        if (!isFoundSum)
        {
            Console.WriteLine("There is no such sum.");
        }
        else
        {
            Console.WriteLine("Number of such sums: {0}", numOfSums);
        }   
    }
}
