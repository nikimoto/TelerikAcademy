using System;

class Dictionary
{
    static void Main()
    {
        string[] dictionary = { ".NET - platform for applications from Microsoft",
                                "CLR - managed execution environment for .NET",
                                "namespace - hierarchical - organization of classes",
                              "Java - object-oriented programming language, similar to C#",
                              "Javascript - web programming language"};
        string word = Console.ReadLine();
        foreach (string line in dictionary)
        {
            if (line.IndexOf(word + " -") == 0)
            {
                Console.WriteLine(line);
            }
        }
    }
}
