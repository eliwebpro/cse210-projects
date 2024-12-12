using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Rectangle("Green", 2, 5));
        shapes.Add(new Circle("Red", 3));
        shapes.Add(new Square("Brown", 5));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape color: {shape.GetColor()}");
            Console.WriteLine($"Shape area: {shape.GetArea()}");
        }

    }
}