using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Blue", 2.5);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Yellow", 3.5, 2.8);
        shapes.Add(rectangle);

        Circle circle = new Circle("Green", 3.0);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}.");
        }

    }
}