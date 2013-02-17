using System;
using System.Collections.Generic;
using System.Linq;


class ArithmeticWithTwoPolynomials
{
    static int[] FillArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int num = int.Parse(Console.ReadLine());
            arr[i] = num;
        }
        Array.Reverse(arr);
        return arr;
    }  

    static void PrintPolynom(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] != 0)
            {
                if (i != 0 && i != 1)
                {
                    Console.Write(" {2}{0}x^{1}", arr[i], i, ReturnPositiveSign(arr, i));
                }
                else if (i == 1)
                {
                    Console.Write(" {1}{0}x", arr[i], ReturnPositiveSign(arr, i));

                }
                else if (i == 0)
                {
                    Console.Write(" {1}{0}", arr[i], ReturnPositiveSign(arr, i));
                }
            }
        }
        Console.WriteLine();
    }

    static string ReturnPositiveSign(int[] arr, int i)
    {
        if (arr[i] > 0 && arr.Length - 1 != i)
        {
            string signPlus = " +";
            return signPlus;
        }
        else
        {
            return string.Empty;
        }
    }

    static int[] SumTwoArrays(int[] arr1, int[] arr2)
    {
        int biggerLength = arr1.Length;
        int smallerLength = arr2.Length;

        if (arr2.Length > arr1.Length)
        {
            biggerLength = arr2.Length;
            smallerLength = arr1.Length;
        }
        int[] sumArr = new int[biggerLength];

        for (int i  = 0; i  < sumArr.Length; i ++)
        {
            if (i > smallerLength - 1)
            {
                sumArr[i] = arr1.Length > arr2.Length ? arr1[i] : arr2[i];
            }
            else
            {
                sumArr[i] = arr1[i] + arr2[i];
            }
        }
        return sumArr;
    }

    static int[] SubstractTwoArrays(int[] arr1, int[] arr2)
    {

        int biggerLength = arr1.Length;
        int smallerLength = arr2.Length;

        if (arr2.Length > arr1.Length)
        {
            biggerLength = arr2.Length;
            smallerLength = arr1.Length;
        }

        int[] subArr = new int[biggerLength];

        for (int i = 0; i < biggerLength; i++)
        {
            if (i > smallerLength - 1)
            {
                subArr[i] = arr1.Length > arr2.Length ? arr1[i] : arr2[i];
            }
            else
            {
                subArr[i] = arr1[i] - arr2[i];
            }
        }
        return subArr;
    }

    static int[] MultiplyTwoArr(int[] arr1, int[] arr2)
    {
        int[] multiArr = new int[arr1.Length + arr2.Length - 1];
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                multiArr[i + j] += arr1[i] * arr2[j];
            }

        }
        return multiArr;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter degree of your 1 polynomial:");
        int degree = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient from higest to smallest [x^2 => x^0]:");
        int[] arr1 = new int[degree + 1];

        Console.WriteLine("Enter values:");
        FillArray(arr1);

        Console.Write("Enter degree of your 2 polynomial:");
        degree = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient from higest to smallest [x^2 => x^0]:");
        int[] arr2 = new int[degree + 1];

        Console.WriteLine("Enter values:");
        FillArray(arr2);

        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Array 1:                 ");
        PrintPolynom(arr1);
        Console.Write("Array 2:                 ");
        PrintPolynom(arr2);
        Console.WriteLine();

        Console.Write("Sum:                     ");
        PrintPolynom(SumTwoArrays(arr1, arr2));


        Console.Write("Subtraction:             ");
        PrintPolynom(SubstractTwoArrays(arr1, arr2));


        Console.Write("Multiplication:          ");
        PrintPolynom(MultiplyTwoArr(arr1, arr2));
        Console.WriteLine();
        Console.WriteLine();
    }
}
