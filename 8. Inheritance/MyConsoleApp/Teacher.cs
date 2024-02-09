using System;

class Teacher : Person
{
    public Teacher(string name) : base(name)
    {
    }

    public void Explain()
    {
        Console.WriteLine($"Teacher {Name} is explaining.");
    }
}