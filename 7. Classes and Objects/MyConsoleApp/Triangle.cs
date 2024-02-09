using System;

class Triangle
{
    public Point Vertex1;
    public Point Vertex2;
    public Point Vertex3;

    public Triangle(Point v1, Point v2, Point v3)
    {
        Vertex1 = new Point(v1);
        Vertex2 = new Point(v2);
        Vertex3 = new Point(v3);
    }

    public static Triangle ReadTriangle()
    {
        Console.WriteLine("Enter vertices for Triangle:");
        Point v1 = Point.ReadPoint();
        Point v2 = Point.ReadPoint();
        Point v3 = Point.ReadPoint();

        return new Triangle(v1, v2, v3);
    }

    public void DisplayTriangle()
    {
        Console.WriteLine("Triangle Vertices:");
        Vertex1.DisplayPoint();
        Vertex2.DisplayPoint();
        Vertex3.DisplayPoint();
    }

    public double CalculatePerimeter()
    {
        double side1 = Point.CalculateDistance(Vertex1, Vertex2);
        double side2 = Point.CalculateDistance(Vertex2, Vertex3);
        double side3 = Point.CalculateDistance(Vertex3, Vertex1);

        return side1 + side2 + side3;
    }

    public double CalculateArea()
    {
        double side1 = Point.CalculateDistance(Vertex1, Vertex2);
        double side2 = Point.CalculateDistance(Vertex2, Vertex3);
        double side3 = Point.CalculateDistance(Vertex3, Vertex1);

        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }
}