using System;
using System.Collections.Generic;



class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter the size ot the first array: ");
        string cInput = Console.ReadLine();
        int number1 = int.Parse(cInput);
        int[] array1 = new int[number1];      

        for (int index = 0; index < number1; index++)
        {
            Console.Write("array1 [{0}] = ",index);
            array1[index] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the size ot the second array: ");
        cInput = Console.ReadLine();
        int number2 = int.Parse(cInput);
        int[] array2 = new int[number2];

        for (int index = 0; index < number2; index++)
        {
            Console.Write("array2 [{0}] = ", index);
            array2[index] = int.Parse(Console.ReadLine());
        }

        bool isEqual = true;

        if (array1.Length == array2.Length)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    isEqual = false;
                    break;
                }
            }
            if (isEqual)
            {
                Console.WriteLine("The arrays are the same!");
                Console.WriteLine("Equal? -> {0}", isEqual);
            }
            else 
            {
                Console.WriteLine("The arrays are NOT the same!");
                Console.WriteLine("Equal? -> {0}", isEqual);
            }
            
        }
        else
        {
            Console.WriteLine("The arrays are not with same sizes");
            Console.WriteLine("Equal? -> {0}", isEqual);
        }
    }
}
