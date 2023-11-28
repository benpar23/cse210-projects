using System;
using System.Collections.ObjectModel;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> list = new List<Shape>();
        
        Square square = new Square("red", 5);

        list.Add(square);

        Rectangle rectangle = new Rectangle("blue", 4, 7);

        list.Add(rectangle);

        Circle circle = new Circle("yellow", 9);

        list.Add(circle);

        foreach (Shape shape in list)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
    }
}