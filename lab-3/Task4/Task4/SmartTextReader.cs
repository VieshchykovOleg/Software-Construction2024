using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SmartTextReader : ISmartTextReader
{
    private string filePath;

    public SmartTextReader(string filePath)
    {
        this.filePath = filePath;
    }

    public char[,] ReadText()
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            // Finding the length of the longest line
            int maxLength = 0;
            foreach (string line in lines)
            {
                if (line.Length > maxLength)
                {
                    maxLength = line.Length;
                }
            }
            char[,] text = new char[lines.Length, maxLength];
            for (int i = 0; i < lines.Length; i++)
            {
                char[] chars = lines[i].ToCharArray();
                for (int j = 0; j < chars.Length; j++)
                {
                    text[i, j] = chars[j];
                }
            }

            return text;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
            return null;
        }
    }
}