using System;


class GenerateRandomValues
{    
    static void Main()
    {
        Random rand = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("number {1}: {0}", rand.Next(100, 201), i + 1);
        }

    }
}
