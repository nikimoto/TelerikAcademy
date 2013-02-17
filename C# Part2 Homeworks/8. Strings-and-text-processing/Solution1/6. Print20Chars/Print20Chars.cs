using System;

class Print20Chars
{
    static void Main()
    {
        Console.WriteLine("Enter string of max 20 chars:");
        string input = Console.ReadLine();
        int max = 20;       
        if (input.Length <= max)
        {
            Console.WriteLine(input.PadRight(max, '*'));
        }
        else
        {
            Console.WriteLine("You entered > 20 chars!");
        }        
    }
}
