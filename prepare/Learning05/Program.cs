using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 4);
        Console.WriteLine($"{square.GetColor()} {square.GetArea()}");

        Rectangle rectangle = new Rectangle("red", 3, 6);
        Console.WriteLine($"{rectangle.GetColor()} {rectangle.GetArea()}");

        Circle circle = new Circle("white", 4);
        Console.WriteLine($"{circle.GetColor()} {circle.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}.");
        }
    }
}