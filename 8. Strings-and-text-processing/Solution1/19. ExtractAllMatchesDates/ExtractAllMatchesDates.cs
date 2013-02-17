using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

class ExtractAllMatchesDates
{
    static void Main(string[] args)
    {
        string text = @"Краен срок: 23:59 часа на 31.01.2013.
        Видео - 22.01.2013.
        Видео - 23 януари 2013. - Наков.
        Видео - 23.01.2013. - Наков.
        Краен срок: 23:59 часа на 03.02.2013.";

        string[] words = text.Split(new char[] { ' ', '?', '!', ';', ',', '\n', '\t', '\r' },StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            try
            {
                DateTime date = DateTime.ParseExact(word, "dd.MM.yyyy.", CultureInfo.InvariantCulture);
                Console.WriteLine("Bulgarian format: {0}", date);
                Console.WriteLine("Canadian format: {0}",date.ToString("dd/MM/yy", CultureInfo.GetCultureInfo("en-CA")));
                Console.WriteLine();
            }
            catch (Exception)
            {
               
            }           
        }       
    }
}
