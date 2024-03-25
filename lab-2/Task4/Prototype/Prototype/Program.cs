using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Virus firstGeneration = new Virus(0.5, 1, "Вірус1", "ТипA");
        firstGeneration.Children.Add(new Virus(0.3, 1, "Вірус1.1", "ТипA"));
        firstGeneration.Children.Add(new Virus(0.4, 1, "Вірус1.2", "ТипB"));

        Virus secondGeneration = (Virus)firstGeneration.Clone();
        secondGeneration.Name = "Вірус2";
        foreach (var child in secondGeneration.Children)
        {
            child.Age++;
        }

        Virus thirdGeneration = (Virus)secondGeneration.Clone();
        thirdGeneration.Name = "Вірус3";
        foreach (var child in thirdGeneration.Children)
        {
            child.Age++;
        }

        Console.WriteLine("Перше покоління:");
        firstGeneration.DisplayInfo();

        Console.WriteLine("\nДруге покоління:");
        secondGeneration.DisplayInfo();

        Console.WriteLine("\nТретє покоління:");
        thirdGeneration.DisplayInfo();
    }
}
