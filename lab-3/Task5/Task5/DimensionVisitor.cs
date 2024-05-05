using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DimensionVisitor : IVisitor
{
    public void VisitElement(LightElementNode element)
    {
        // Обчислення розмірів елемента
        Console.WriteLine($"Calculating dimensions for element: {element.TagName}");
    }

    public void VisitTextNode(LightTextNode textNode)
    {
        // Обчислення розмірів текстового вузла
        Console.WriteLine($"Calculating dimensions for text node: {textNode.Text}");
    }
}
