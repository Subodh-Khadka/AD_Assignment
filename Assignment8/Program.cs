using System;

public struct Point2D
{
    public float X { get; private set; }
    public float Y { get; private set; }

    public Point2D(float x, float y)
    {
        X = x;
        Y = y;
    }

    public float CalculateDistance(Point2D otherPoint)
    {
        float X2 = X - otherPoint.X;
        float Y2 = Y - otherPoint.Y;
        return (float)Math.Sqrt(X2 * X2 + Y2 * Y2);
    }
}

public class Program
{
    public static void Main()
    {
        Point2D point1 = new Point2D(10.0f, 21.0f);
        Point2D point2 = new Point2D(2.0f, 13.0f);
        float distance = point1.CalculateDistance(point2);
        Console.WriteLine($"Distance between point1 and point2: {distance}");
    }
}