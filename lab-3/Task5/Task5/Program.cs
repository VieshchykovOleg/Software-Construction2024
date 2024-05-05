using System;
using System.Collections.Generic;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення елемента і текстового вузла
            LightElementNode element = new LightElementNode("div", DisplayType.Block, ClosingType.WithClosingTag);
            LightTextNode textNode = new LightTextNode("Sample text");

            // Створення відвідувача
            IVisitor visitor = new DimensionVisitor();

            visitor.VisitElement(element);
            visitor.VisitTextNode(textNode);
        }
    }



}
