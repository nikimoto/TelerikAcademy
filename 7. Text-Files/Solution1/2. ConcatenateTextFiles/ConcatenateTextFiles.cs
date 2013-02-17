using System;
using System.IO;


class ConcatenateTextFiles
{
    static void Main()
    {
        string file1 = @"..\..\Sometext.txt";
        string file2 = @"..\..\Some Other Text.txt";
        string fileNew = @"..\..\Concatenated File.txt";
        string line1;
        string line2;
        StreamReader reader1 = new StreamReader(file1);
        StreamReader reader2 = new StreamReader(file2);        
        StreamWriter writer = new StreamWriter(fileNew);

        try
        {
            using (reader1)
            {
                using (reader2)
                {
                    using (writer)
                    {
                        line1 = reader1.ReadLine();
                        while (line1 != null)
                        {
                            writer.WriteLine(line1);
                            line1 = reader1.ReadLine();
                        }

                        line2 = reader2.ReadLine();
                        while (line2 != null)
                        {
                            writer.WriteLine(line2);
                            line2 = reader2.ReadLine();
                        }
                    }
                }
            }
        }            
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine("Invalid directory in the file path.");
        }
        catch (IOException e)
        {
            Console.Error.WriteLine(e.Message);
        }
        Console.WriteLine("File is written!");
        Console.WriteLine("New file content:\n ");

        StreamReader reader = new StreamReader (fileNew);
        using (reader)
        {
            string allText = reader.ReadToEnd();
            Console.WriteLine(allText);
        }
    }
}
