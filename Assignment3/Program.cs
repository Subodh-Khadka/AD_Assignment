using System;

public class Rectangle
{
    private float length;
    private float width;

    public Rectangle(float length, float width)
    {
        this.length = length;
        this.width = width;
    }

    public float CalculateArea()
    {
        return length * width;
    }
}

public class Program
{
    public static void Main()
    {
        Rectangle myRectangle = new Rectangle(4.5f, 3.2f);
        float area = myRectangle.CalculateArea();
        Console.WriteLine("The area of the rectangle is: " + area);
    }
}