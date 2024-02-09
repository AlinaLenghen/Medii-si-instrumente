using System;

class Program
{
    static void Main()
    {
        Point point1 = Point.ReadPoint();
        Point point2 = Point.ReadPoint();

        point1.DisplayPoint();
        point2.DisplayPoint();

        double distance = Point.CalculateDistance(point1, point2);
        Console.WriteLine($"Distance between points: {distance}");

        Triangle triangle = Triangle.ReadTriangle();
        triangle.DisplayTriangle();

        double perimeter = triangle.CalculatePerimeter();
        double area = triangle.CalculateArea();

        Console.WriteLine($"Perimeter of the triangle: {perimeter}");
        Console.WriteLine($"Area of the triangle: {area}");
    }
}