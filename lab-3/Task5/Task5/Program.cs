using System;
using System.Collections.Generic;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            LightElementNode element = new LightElementNode("div", DisplayType.Block, ClosingType.WithClosingTag);
            IState state = new VisibleState(element);
            state.Handle();
            Console.WriteLine(element.OuterHTML);
        }
    }



}
