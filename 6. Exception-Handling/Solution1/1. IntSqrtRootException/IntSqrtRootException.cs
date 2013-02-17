using System;


class IntSqrtRootException
{
    public static double Sqrt(int number)
    {
        if (number < 0)
        {
            throw new System.ArgumentOutOfRangeException("Sqrt for negative numbers is undefined!");
        }
        return Math.Sqrt(number);
    }

    static void Main()
    {
        Console.Write("Enter a number to calculate it's square root: ");
        try
        {
            int number = int.Parse(Console.ReadLine());
            double result = Sqrt(number);
            Console.WriteLine("The root is: {0}", result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Parse faild! This is not an integer number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is too big to fill in Int32.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Good Bye");
        }
    }
}
