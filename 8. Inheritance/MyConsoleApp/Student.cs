using System;

class Student : Person
{
    public Student(string name) : base(name)
    {
    }

    public void Study()
    {
        Console.WriteLine($"Student {Name} is studying.");
    }
}