using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // File path
            string filePath = @"E:\2_cyrs\2semestr\Software-Construction2024\lab-3\Task4\file.txt";

            // Creating SmartTextReader proxy class
            ISmartTextReader textReader = new SmartTextReaderProxy(filePath);

            // Reading the file
            char[,] text = textReader.ReadText();

            // Displaying the result
            if (text != null)
            {
                Console.WriteLine("Text read successfully:");
                for (int i = 0; i < text.GetLength(0); i++)
                {
                    for (int j = 0; j < text.GetLength(1); j++)
                    {
                        Console.Write(text[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

    

   
