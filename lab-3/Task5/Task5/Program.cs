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
            LightTextNode textNode = new LightTextNode("babana dance!");

            h1.AddChild(textNode);
            body.AddChild(h1);
            Console.WriteLine(body.OuterHTML);
        }
    }

  
}
