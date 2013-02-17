using System;


class PrintMyName
{
    static void PrintName(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
        Console.WriteLine("Please, enter your name: ");
        string fname = Console.ReadLine();
        PrintName(fname);
    }
}
