public class Circle: Shape{

private double _radius;

public Circle(string color, double radius):base(color)
{

_radius = radius;

}
    public override double GetArea()
    {
        // had to peek at the insturctor answer because I had a brain fart trying to remember how to calculate the area of a circle. 
        return _radius * _radius * Math.PI;

    }

}