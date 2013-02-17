using System;
using System.Collections.Generic;

class MenuForMultypleTasks
{
    static char[] ReverseDigitsOfDecimal(decimal number)
    {
        string strNumber = number.ToString();        
        char[] reversed = new char[strNumber.Length];
        for (int i = strNumber.Length - 1, j = 0; i >= 0; i--, j++)
        {
            reversed[j] = strNumber[i];
        }
        return reversed;
    }

    static int ReverseDigits(int number)
    {
        int reversed = 0;
        while (number > 0)
        {
            reversed = (number % 10) + (reversed * 10);
            number /= 10;
        }
        return reversed;
    }

    static double CalculateAverage(int[] sequence)
    {
        int sequenceLength = sequence.Length;
        double sum = 0;
        foreach (int num in sequence)
        {
            sum += num;
        }
        return sum / sequenceLength;
    }

    static double LinearEquation(double a, double b)
    {
        return -b / a;
    }

    static int[] FillSequence(int[] arr, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("Element[{0}]", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        return arr;
    }

    static void  PrintCharArray(char[] number)
    {        
        for (int i = 0; i < number.Length; i++)
        {
            Console.Write(number[i]);
        }
        Console.WriteLine();
    }

    static void PrintMenu()
    {        
        Console.WriteLine("+----------------------MENU-------------------------+");
        Console.WriteLine("|1. Reverse the digits of a non negative number.    |");
        Console.WriteLine("|2. Calculate the avarage of a sequence of integers.|");
        Console.WriteLine("|3. Solve a linear equation a * x + b = 0 .         |");
        Console.WriteLine("+---------------------------------------------------+");
        Console.Write("Choose a task number: ");
    }

    static void ReadInput()
    {
        int task = int.Parse(Console.ReadLine());

        if (task <= 0 || task > 3)
        {
            Console.WriteLine("Invalid choise of task");
        }
        else if (task == 1)
        {
            //int number;
            decimal number;
            bool isValidDecimal=false;
            do
            {
                Console.Write("Enter a non-negative number: ");                
                isValidDecimal = decimal.TryParse(Console.ReadLine(), out number);
                if (number < 0) Console.WriteLine("The number is not valid! \n");
                else if (!isValidDecimal) Console.WriteLine("For demical separator use ','!");
            }
            while (number < 0 || !isValidDecimal);
            //int reversed = ReverseDigits(number);            
            Console.Write("The reversed number is: ");
            PrintCharArray(ReverseDigitsOfDecimal(number));
        }
        else if (task == 2)
        {
            int sequenceLength;
            do
            {
                Console.Write("Enter the length of the integer sequence: ");
                sequenceLength = int.Parse(Console.ReadLine());
                if (sequenceLength <= 0)
                {
                    Console.WriteLine("The length you have entered is invalid.");
                }
            }
            while (sequenceLength <= 0);

            int[] sequence = new int[sequenceLength];
            Console.WriteLine("Enter the elements of the sequence:");
            FillSequence(sequence, sequenceLength);

            double average = CalculateAverage(sequence);
            Console.WriteLine("The average value is: {0}", average);
        }
        else
        {
            Console.WriteLine("Enter the coefficients of the equation: ");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            if (a == 0.0 && b != 0.0)
            {
                Console.WriteLine("The equation can't be solved because a = 0 and b != 0");
            }
            else if (a == 0.0 && b == 0.0)
            {
                Console.WriteLine("Every x is solution to the equation.");
            }
            else
            {
                double result = LinearEquation(a, b);
                Console.WriteLine("The root x = {0}", result);
            }
        }
    }


    static void Main(string[] args)
    {
        PrintMenu();
        ReadInput();        
    }    
}
