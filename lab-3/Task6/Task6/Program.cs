using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using HtmlAgilityPack;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookUrl = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";
            string bookText;
            using (WebClient client = new WebClient())
            {
                bookText = client.DownloadString(bookUrl);
            }
            var sentences = GetSentences(bookText);
            int totalMemoryConsumption = 0;
            foreach (var sentence in sentences)
            {
                var html = ConvertSentenceToHtml(sentence, out int memoryConsumption);
                totalMemoryConsumption += memoryConsumption;
                Console.WriteLine(html.OuterHTML);
            }
            Console.WriteLine($"Total memory consumption of the HTML tree: {totalMemoryConsumption} bytes");
        }

        static List<string> GetSentences(string text)
        {
            return text.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries)
                       .Select(sentence => sentence.Trim())
                       .ToList();
        }

        static LightElementNode ConvertSentenceToHtml(string sentence, out int memoryConsumption)
        {
            LightElementNode paragraph = new LightElementNode("p", DisplayType.Block, ClosingType.WithClosingTag);
            paragraph.AddChild(new LightTextNode(sentence));
            memoryConsumption = CalculateMemoryConsumption(paragraph);
            return paragraph;
        }

        static int CalculateMemoryConsumption(LightNode node)
        {
            int size = 0;
            if (node is LightElementNode elementNode)
            {
                size += sizeof(int);
                size += elementNode.TagName.Length * sizeof(char);
                size += elementNode.Classes.Sum(c => c.Length * sizeof(char));
                size += sizeof(int);
                size += sizeof(int);
                size += sizeof(int);
                size += sizeof(int);
                foreach (var child in elementNode.Children)
                {
                    size += CalculateMemoryConsumption(child);
                }
            }
            else if (node is LightTextNode textNode)
            {
                size += textNode.Text.Length * sizeof(char);
            }
            size += sizeof(int);
            return size;
        }
    }   
}
