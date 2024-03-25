using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Virus : ICloneable
{
    public double Weight { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public List<Virus> Children { get; set; }

    public Virus(double weight, int age, string name, string species)
    {
        Weight = weight;
        Age = age;
        Name = name;
        Species = species;
        Children = new List<Virus>();
    }

    public object Clone()
    {
        Virus clone = new Virus(Weight, Age, Name, Species);
        foreach (var child in Children)
        {
            clone.Children.Add((Virus)child.Clone());
        }
        return clone;
    }

    public void DisplayInfo()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine($"Ім'я: {Name}, Вид: {Species}, Вага: {Weight}, Вік: {Age}");
        if (Children.Count > 0)
        {
            Console.WriteLine("Діти:");
            foreach (var child in Children)
            {
                child.DisplayInfo();
            }
        }
    }
}