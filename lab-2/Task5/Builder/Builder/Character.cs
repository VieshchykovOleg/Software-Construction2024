using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Character
{
    public double Height { get; set; }
    public string Build { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    public string Clothing { get; set; }
    public string Inventory { get; set; }

    public void DisplayInfo()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine($"Висота: {Height}");
        Console.WriteLine($"Статура: {Build}");
        Console.WriteLine($"Колір волосся: {HairColor}");
        Console.WriteLine($"Колір очей: {EyeColor}");
        Console.WriteLine($"Одяг: {Clothing}");
        Console.WriteLine($"Інвентар: {Inventory}");
    }
}