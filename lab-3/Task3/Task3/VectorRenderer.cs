using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class VectorRenderer : Renderer
{
    public override void RenderCircle()
    {
        Console.WriteLine("Drawing Circle as vectors");
    }

    public override void RenderSquare()
    {
        Console.WriteLine("Drawing Square as vectors");
    }

    public override void RenderTriangle()
    {
        Console.WriteLine("Drawing Triangle as vectors");
    }
}
