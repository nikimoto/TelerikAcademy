using System;


class ReadNumberMethodEx
{
    public static void ReadNumber(int start, int end)
    {
        if (start > end)
        {
            int temp = start;
            start = end;
            end = temp;
        }
        Console.WriteLine("Enter numbers in the range [{0} ... {1}]", start, end);
        Console.WriteLine("Each entered number should be greater than the previous.");        
        int number = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Number {0} = ", i + 1);
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                throw;
            }   

            if ((end < number) || (start > number))
            {
                throw new System.ArgumentOutOfRangeException();
            }            
            start = number;           
        }        
    }

    static void Main()
    {
        Console.WriteLine("This program reads 10 number in choosen (e.g. 1..100)");
        Console.Write("Enter start number: ");
        int start;
        int end;
        try
        {
            start = int.Parse(Console.ReadLine());
            Console.Write("Enter end number: ");
            end = int.Parse(Console.ReadLine());
            ReadNumber(start, end);
        }
        catch (FormatException)
        {
            Console.WriteLine("Parse faild! This is not an integer number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is too big to fill in Int32.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The entered number is not in range.");
        }        
    }
}
