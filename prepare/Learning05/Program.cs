using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Blue", 3);
        shapes.Add(square);
        //Testing color and area for square
        // Console.WriteLine(square.GetColor()); 
        // Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("Yellow", 5, 3);
        shapes.Add(rectangle);
        //Testing color and area for rectangle
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("Red", 3);
        shapes.Add(circle);
        //Testing color and area for circle
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());


        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            //display the color and area for each shape in the shapes list
            Console.WriteLine($"Color of the shape: {color}  /  Area of the shape: {area} ");
        }

    }
}