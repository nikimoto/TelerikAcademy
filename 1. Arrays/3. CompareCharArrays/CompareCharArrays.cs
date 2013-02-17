using System;
using System.Collections.Generic;


class CompareCharArrays
{
    static void Main()
    {
        //char[] array1 = { 'a', 'b', 'c', 'd' };
        //char[] array2 = { 'a', 'b', 'c', 'd' };
        //int number1 = array1.Length;
        //int number2 = array2.Length;

        int maxLen;
        int smaller = 0;       

        Console.Write("Enter the size ot the first array: ");
        string cInput = Console.ReadLine();
        int number1 = int.Parse(cInput);
        char[] array1 = new char[number1];

        for (int index = 0; index < number1; index++)
        {
            Console.Write("array1 [{0}] = ", index);
            array1[index] = char.Parse(Console.ReadLine());
        }

        Console.Write("Enter the size ot the second array: ");
        cInput = Console.ReadLine();
        int number2 = int.Parse(cInput);
        char[] array2 = new char[number2];

        for (int index = 0; index < number2; index++)
        {
            Console.Write("array2 [{0}] = ", index);
            array2[index] = char.Parse(Console.ReadLine());
        }

        if (number1 > number2)
        {
            maxLen = number2;
            smaller = 2;
        }
        else if (number1 < number2)
        {
            maxLen = number1;
            smaller = 1;
        }
        else
        {
            maxLen = number1;
            for (int i = 0; i < maxLen; i++)
            {
                if (array1[i] < array2[i])
                {
                    smaller = 1;
                    break;
                }
                else if (array1[i] > array2[i])
                {
                    smaller = 2;
                    break;
                }
            }
        }
        switch (smaller)
        {
            case 1:
                Console.WriteLine("The FIRST array is earlier in lexicographical order");
                break;
            case 2: 
                Console.WriteLine("The SECOND array is earlier in lexicographical order");
                break;
            case 0:
                Console.WriteLine("The two arrays are the same!");
                break;
            default:
                Console.WriteLine("Error!");
                break;
        }

        //bool isEqual = false;

        //if (array1.Length == array2.Length)
        //{
        //    for (int i = 0; i < array1.Length; i++)
        //    {
        //        if (array1[i] == array2[i])
        //        {
        //            isEqual = true;
        //        }
        //        else 
        //        {
        //            isEqual = false;
        //        }
        //    }
        //    if (isEqual)
        //    {
        //        Console.WriteLine("The arrays are the same!");
        //        Console.WriteLine("Equal? -> {0}", isEqual);
        //    }
        //    else
        //    {
        //        Console.WriteLine("The arrays are NOT the same!");
        //        Console.WriteLine("Equal? -> {0}", isEqual); 
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("The arrays are not with same sizes");
        //    Console.WriteLine("Equal? -> {0}", isEqual);
        //}
    }
}
