//Open/Closed principle: Class should be open for extension and closed for modification

//Let's say we have a rectangle class:
public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
}

//And another class AreaCalculator used to calculate area
public class AreaCalculator
{
    public double Area(Rectangle[] shapes)
    {
        double area = 0;
        foreach (var shape in shapes)
        {
            area += shape.Width * shape.Height;
        }
        return area;
    }
}

//Everything goes well until we introduce a different kind of shape, a circle. Now we need to add if/else logic and modify the AreaCalculator class:
public double Area(object[] shapes)
{
    double area = 0;
    foreach (var shape in shapes)
    {
        if (shape is Rectangle)
        {
            Rectangle rectangle = (Rectangle) shape;
            area += rectangle.Width*rectangle.Height;
        }
        else
        {
            Circle circle = (Circle)shape;
            area += circle.Radius * circle.Radius * Math.PI;
        }
    }
    return area;
}

//Let's add an abstract class Shape having abstract method double
public abstract class Shape
{
    public abstract double Area();
}

//Now we can make Rectangle and Circle inherit from the Shape class:
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double Area()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }
    public override double Area()
    {
        return Radius * Radius*Math.PI;
    }
}

//And the Area method of AreaCalculator does not need to be modified
public double Area(Shape[] shapes)
{
    double area = 0;
    foreach (var shape in shapes)
    {
        area += shape.Area();
    }
    return area;
}



