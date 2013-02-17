using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class RemoveOddLines
{
    static string fileName = @"..\..\RemoveOddLines.txt";

    static List<string> GetEvenLines(string filename)
    {
        List<string> evenLines = new List<string>();
        int counter = 1;

        using (StreamReader reader = new StreamReader(filename))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                if (counter % 2 == 0)
                {
                    evenLines.Add(line);
                }
                counter++;
                line = reader.ReadLine();
            }
        }
        return evenLines;
    }

    static void EditFile(List<string> lines)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (string line in lines)
            {
                writer.WriteLine(line);
            }
        }
    }

    static void Main()
    {
        EditFile(GetEvenLines(fileName));
        Console.WriteLine("File is written! Check RemoveOddLines.txt");
    }
}
