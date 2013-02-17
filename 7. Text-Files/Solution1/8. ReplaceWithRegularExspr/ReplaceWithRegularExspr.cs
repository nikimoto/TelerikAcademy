using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ReplaceWithRegularExspr
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
                    writer.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                    line = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("Check the output file.");
    }
}
