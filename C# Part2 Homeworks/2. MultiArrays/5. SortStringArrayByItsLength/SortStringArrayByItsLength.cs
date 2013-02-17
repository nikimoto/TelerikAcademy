using System;
using System.Collections.Generic;


class SortStringArrayByItsLength
{
    class StringComparer : IComparer<string>
    {
        public int Compare (string a, string b)
        {
            if (a.ToString().Length != b.ToString().Length)
            {
                return a.ToString().Length.CompareTo(b.ToString().Length);
            }
            else 
            {
                return a.ToString().CompareTo(b.ToString());
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter the array's size: ");
        int size = int.Parse(Console.ReadLine());
        string[] array = new string[size];

        Console.WriteLine("Input the elements of the array: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write("Element {0} = ", i);
            array[i] = Console.ReadLine();
        }

        Array.Sort(array, new StringComparer());

        foreach (var element in array)
        {
            Console.WriteLine("{0}", element);
        }
        Console.WriteLine();
    }
}

