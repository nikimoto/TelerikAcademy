using System;
using System.IO;


class ReadFileAndPrintOddLines
{
    static void Main()
    {
        string filename = @"..\..\ReadFileAndPrintOddLines.cs";
        Console.WriteLine("Print odd lines of file {0}: ", filename);
        Console.WriteLine();
        StreamReader reader = new StreamReader(filename);

        using (reader)
        {
            int oddLines = 0;
            string oddLine = reader.ReadLine();
            while (oddLine != null)
            {
                oddLines++;
                if (oddLines % 2 == 1)
                {
                    Console.WriteLine("Line {0}: {1} ",oddLines, oddLine);
                }
                oddLine = reader.ReadLine();
            }
        }
    }
}
