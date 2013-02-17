using System;
using System.Collections.Generic;
using System.IO;


class SortingNamesInFiles
{
    static List<string> GetNames(string fileName)
    {
        List<string> names = new List<string>();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                names.Add(line);
                line = reader.ReadLine();
            }
        }
        return names;
    }

    static void WriteToFile(List<string> names, string newFileName)
    {
        using (StreamWriter writer = new StreamWriter(newFileName))
        {
            for (int i = 0; i < names.Count; i++)
            {
                writer.WriteLine(names[i]);
            }
        }
        Console.WriteLine("Writing is complete! You have sorted names in the output file {0}.", newFileName);
    }

    static void Main()
    {
        string firstFileName = "../../names.txt";
        string newFileName = "../../sorted names.txt";

        List<string> names = GetNames(firstFileName);
        names.Sort();
        WriteToFile(names, newFileName);

    }
}
