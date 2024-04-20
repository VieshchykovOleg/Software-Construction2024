using System;
using System.Collections.Generic;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            LightElementNode body = new LightElementNode("body", DisplayType.Block, ClosingType.WithClosingTag);
            LightElementNode h1 = new LightElementNode("h1", DisplayType.Block, ClosingType.WithClosingTag);
            LightTextNode textNode = new LightTextNode("banana dance!");

            h1.AddChild(textNode);
            body.AddChild(h1);

            h1.AddEventListener("click", () =>
            {
                Console.WriteLine("Clicked on h1 element!");
            });

            Console.WriteLine(body.OuterHTML);
        }
    }
}
