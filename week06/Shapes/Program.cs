using System;
using System.Security.Cryptography.X509Certificates;
using Shapes;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("Red", 20);
        Rectangle rectangle = new Rectangle("Blue", 10, 20);
        Circle circle = new Circle("Purple", 3.5);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(var s in shapes)
        {
            Console.WriteLine($"color: {s.GetColor()}, Area: {s.GetArea()}");
        }
    }
}