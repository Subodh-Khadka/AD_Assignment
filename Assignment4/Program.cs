using System;

public class Shape
{
    public virtual float CalculateArea()
    {
        return 0;
    }
}

public class Circle : Shape
{
    private float radius;

    public Circle(float radius)
    {
        this.radius = radius;
    }

    public override float CalculateArea()
    {
        return 3.14159f * radius * radius;
    }
}

public class Program
{
    public static void Main()
    {
        Circle myCircle = new Circle(5);
        float area = myCircle.CalculateArea();
        Console.WriteLine("The area of the circle is: " + area);
    }
}
