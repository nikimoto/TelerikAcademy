using System;
using System.Collections.Generic;
using System.Linq;


class RemainingSortedArray
{
    static bool IsSorted(List<int> list)
    {
        bool isSorted = true;

        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i] > list[i + 1])
            {
                isSorted = false;
            }
        }
        return isSorted;
    }

    static void PrintArray(List<int> list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter the array's size: ");
        int size = int.Parse(Console.ReadLine());
        List<int> arrayList = new List<int>(size);

        Console.WriteLine("Enter the array's elements: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write("array[{0}]:", i);
            arrayList.Add(int.Parse(Console.ReadLine()));
        }        

        //List<int> arrayList = new List<int>() { 6, 1, 4, 3, 0, 3, 6, 4, 5 }; //{ 6, 1, 4, 3, 0, 3, 6, 4, 5, 6, 9, 0, 7, 8 };
        List<int> result = new List<int>();

        int maxSubArrays = (int)Math.Pow(2, arrayList.Count)-1;
        int maxElements = 0;

        for (int i = 1; i <= maxSubArrays; i++)
        {
            List<int> tempArrayList = new List<int>();
            int counter = 0;

            for (int j = 0; j <= arrayList.Count; j++)
            {
                int mask = i >> j;                
                if ((mask & 1) == 1)
                {
                    tempArrayList.Add(arrayList[j]);
                    counter++;
                }
            }
            if (counter > maxElements && IsSorted(tempArrayList))
            {
                result = tempArrayList;
                maxElements = counter;
            }
        }
        PrintArray(result);
    }
}
