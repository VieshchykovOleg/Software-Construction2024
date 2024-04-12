using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Triangle : Shape
{
    public Triangle(Renderer renderer) : base(renderer) { }

    public override void Draw()
    {
        renderer.RenderTriangle();
    }
}
