using System;

class Rational
{
    private int numerator;
    private int denominator;

    public Rational(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }

        this.numerator = numerator;
        this.denominator = denominator;

        Simplify();
    }

    private void Simplify()
    {
        int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
        numerator /= gcd;
        denominator /= gcd;

        // Ensure the sign is attached to the numerator
        if (denominator < 0)
        {
            numerator = -numerator;
            denominator = -denominator;
        }
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public void Display()
    {
        Console.WriteLine($"{numerator}/{denominator}");
    }

    public override string ToString()
    {
        return $"{numerator}/{denominator}";
    }

    public static Rational operator +(Rational r1, Rational r2)
    {
        int newNumerator = r1.numerator * r2.denominator + r2.numerator * r1.denominator;
        int newDenominator = r1.denominator * r2.denominator;
        return new Rational(newNumerator, newDenominator);
    }

    public static Rational operator -(Rational r1, Rational r2)
    {
        int newNumerator = r1.numerator * r2.denominator - r2.numerator * r1.denominator;
        int newDenominator = r1.denominator * r2.denominator;
        return new Rational(newNumerator, newDenominator);
    }

    public static Rational operator *(Rational r1, Rational r2)
    {
        int newNumerator = r1.numerator * r2.numerator;
        int newDenominator = r1.denominator * r2.denominator;
        return new Rational(newNumerator, newDenominator);
    }

    public static Rational operator /(Rational r1, Rational r2)
    {
        if (r2.numerator == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        int newNumerator = r1.numerator * r2.denominator;
        int newDenominator = r1.denominator * r2.numerator;
        return new Rational(newNumerator, newDenominator);
    }

    public static bool operator <(Rational r1, Rational r2)
    {
        return r1.numerator * r2.denominator < r2.numerator * r1.denominator;
    }

    public static bool operator >(Rational r1, Rational r2)
    {
        return r1.numerator * r2.denominator > r2.numerator * r1.denominator;
    }

    public static bool operator <=(Rational r1, Rational r2)
    {
        return r1.numerator * r2.denominator <= r2.numerator * r1.denominator;
    }

    public static bool operator >=(Rational r1, Rational r2)
    {
        return r1.numerator * r2.denominator >= r2.numerator * r1.denominator;
    }

    public static bool operator ==(Rational r1, Rational r2)
    {
        return r1.numerator * r2.denominator == r2.numerator * r1.denominator;
    }

    public static bool operator !=(Rational r1, Rational r2)
    {
        return r1.numerator * r2.denominator != r2.numerator * r1.denominator;
    }

    public override bool Equals(object obj)
    {
        if (obj is Rational other)
        {
            return this == other;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return numerator.GetHashCode() ^ denominator.GetHashCode();
    }
}