using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RasterRenderer : Renderer
{
    public override void RenderCircle()
    {
        Console.WriteLine("Drawing Circle as pixels");
    }

    public override void RenderSquare()
    {
        Console.WriteLine("Drawing Square as pixels");
    }

    public override void RenderTriangle()
    {
        Console.WriteLine("Drawing Triangle as pixels");
    }
}