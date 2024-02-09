using System;



class Program
{
    static void Main()
    {
        Rational r1 = new Rational(1, 2);
        Rational r2 = new Rational(3, 4);

        Console.WriteLine("r1: " + r1);
        Console.WriteLine("r2: " + r2);

        Rational sum = r1 + r2;
        Console.WriteLine("Sum: " + sum);

        Rational difference = r1 - r2;
        Console.WriteLine("Difference: " + difference);

        Rational product = r1 * r2;
        Console.WriteLine("Product: " + product);

        Rational quotient = r1 / r2;
        Console.WriteLine("Quotient: " + quotient);

        Console.WriteLine($"Is {r1} less than {r2}? {r1 < r2}");
        Console.WriteLine($"Is {r1} greater than {r2}? {r1 > r2}");
        Console.WriteLine($"Is {r1} less than or equal to {r2}? {r1 <= r2}");
        Console.WriteLine($"Is {r1} greater than or equal to {r2}? {r1 >= r2}");
        Console.WriteLine($"Is {r1} equal to {r2}? {r1 == r2}");
        Console.WriteLine($"Is {r1} not equal to {r2}? {r1 != r2}");
    }
}
