using System;
using System.Collections.Generic;
using System.IO;

class RemoveWordsByFile
{
    static int ReadWords(List<string> listWords)
    {
        string fileName = string.Empty;

        try
        {
            fileName = @"..\..\Words to remove.txt";
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    listWords.Add(line);
                    line = reader.ReadLine();
                }

            }
            return 1;
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You does not have the required permission for file: {0}", fileName);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File {0} not found", fileName);
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file: {0}", fileName);
        }

        return -1;
    }

    static bool CheckWors(string line, List<string> listWords)
    {
        foreach (var word in listWords)
        {
            if (line == word) return true;
        }

        return false;
    }

    static void Main()
    {
        /*Write a program that removes from a text file all words listed in given another text file.
          Handle all possible exceptions in your methods.*/

        string fileName = @"..\..\All Words.txt";
        string lineContents = string.Empty;
        string fileContents = string.Empty;
        List<string> listWords = new List<string>();

        if (ReadWords(listWords) == -1) return;

        try
        {
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                lineContents = reader.ReadLine();
                while (lineContents != null)
                {
                    string[] line = lineContents.Split(' ');
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (CheckWors(line[i], listWords) == false)
                        {
                            fileContents += line[i];
                            if (i < line.Length - 1) fileContents += " ";
                        }
                    }
                    fileContents += "\r\n";
                    lineContents = reader.ReadLine();
                }
            }

            fileName = @"..\..\Remaining Words.txt";
            StreamWriter writer = new StreamWriter(fileName);
            using (writer)
            {
                writer.Write(fileContents);
            }

        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You does not have the required permission for file: {0}", fileName);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File {0} not found", fileName);
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file: {0}", fileName);
        }

    }
}