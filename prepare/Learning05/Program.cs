using System;

class Program
{  //polymorphism. Key Takeaways being Override and Abtract. 
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Shape Program. Where we make shape.");
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("blue", 3);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("teal", 4.5, 5);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Green", 6.66666);
        shapes.Add(shape3);

        foreach (Shape s in shapes)
        {
           
            string color = s.GetColor();

         
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}