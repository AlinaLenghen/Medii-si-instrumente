using System;

class Point
{
    public int x;
    public int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public Point(Point other)
    {
        this.x = other.x;
        this.y = other.y;
    }

    public static Point ReadPoint()
    {
        Console.Write("Enter x coordinate: ");
        int x = int.Parse(Console.ReadLine()!);

        Console.Write("Enter y coordinate: ");
        int y = int.Parse(Console.ReadLine()!);

        return new Point(x, y);
    }

    public void DisplayPoint()
    {
        Console.WriteLine($"Point: ({x}, {y})");
    }

    public static double CalculateDistance(Point p1, Point p2)
    {
        int dx = p2.x - p1.x;
        int dy = p2.y - p1.y;

        return Math.Sqrt(dx * dx + dy * dy);
    }
}