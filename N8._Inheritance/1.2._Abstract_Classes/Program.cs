// Abstract base class
public abstract class Shape
{
    // Abstract method
    public abstract double GetArea();

    // Concrete method with default implementation
    public virtual double GetPerimeter()
    {
        return 0;
    }

    // Field
    protected string shapeName;

    // Property
    public string ShapeName
    {
        get { return shapeName; }
        set { shapeName = value; }
    }

    // Constructor
    public Shape(string name)
    {
        shapeName = name;
    }
}

// Derived class
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius, string name) : base(name)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}