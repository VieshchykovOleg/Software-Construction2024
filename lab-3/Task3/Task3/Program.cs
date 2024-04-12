using System;

class Program
{
    static void Main()
    {
        Renderer vectorRenderer = new VectorRenderer();
        Shape circle = new Circle(vectorRenderer);
        Shape square = new Square(vectorRenderer);
        Shape triangle = new Triangle(vectorRenderer);

        circle.Draw();
        square.Draw();
        triangle.Draw();

        Console.WriteLine();

        Renderer rasterRenderer = new RasterRenderer();
        circle = new Circle(rasterRenderer);
        square = new Square(rasterRenderer);
        triangle = new Triangle(rasterRenderer);

        circle.Draw();
        square.Draw();
        triangle.Draw();
    }
}
