using System;
using System.Collections.Generic;

class AlpabeticalWordOrder
{
    static void Main()
    {
        string str = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.";
        string[] words = str.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(words);

        Console.WriteLine("Alphabetical order of words: ");
            
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }    
    }
}
