using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;


class ReplaceTwoSubstrings
{
    static void Main()
    {
        string[] words = { "bla", " ", "\r\n", "start", " start ", " ", "re", "zyx", "kacha", "as", "fin" };

        string fileName = @"..\..\testFile.txt";
        string resultFileName = @"..\..\resultFile.txt";
        Random randomGenerator = new Random();

        StreamWriter writer = new StreamWriter(fileName, false);
        using (writer)
        {
            for (int i = 0; i < 100; i++)
            {
                writer.Write(words[randomGenerator.Next(words.Length)]);
            }
        }

        writer = new StreamWriter(resultFileName, false);
        StreamReader reader = new StreamReader(fileName);

        string line;
        using (reader)
        {
            using (writer)
            {
                line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(line.Replace("start", "finish"));
                    line = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("Check the output file.");

        //using (StreamReader input = new StreamReader("../../input.txt"))
        //using (StreamWriter output = new StreamWriter("../../output.txt"))
        //    for (string line; (line = input.ReadLine()) != null; )
        //          output.WriteLine(line.Replace("start", "finish"));             // Exercise 7
        //        //output.WriteLine(Regex.Replace(line, @"\bstart\b", "finish")); // Exercise 8
    }
}
