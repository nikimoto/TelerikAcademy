using System;
using System.IO;


class InsertLineNumbers
{
    static void Main()
    {
        string fileName = @"..\..\InsertLineNumbers.cs";
        string newFile = @"..\..\Text With Lines.txt";
        StreamReader reader = new StreamReader(fileName);

        using (reader)
        {
            StreamWriter writer = new StreamWriter(newFile);

            using (writer)
            {
                string line = reader.ReadLine();
                int countLines = 0;
                while (line != null)
                {
                    countLines++;
                    writer.Write("Line {0}: ", countLines);
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("File is written!");
    }
}
