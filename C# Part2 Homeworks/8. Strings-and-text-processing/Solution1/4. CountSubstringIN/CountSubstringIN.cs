using System;

class CountSubstringIN
{
    static void Main(string[] args)
    {
        string input = @"We are living in an yellow submarine. We don't have anything else. 
                Inside the submarine is very tight. So we are drinking all the day. 
                We will move out of it in 5 days.";
        int count = 0;

        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input.Substring(i, 2).ToLower() == "in")
            {
                count++;
                i++;
            }
        }
        Console.WriteLine("The target substring \"in\" is conyained {0} times in the text", count);
    }
}
