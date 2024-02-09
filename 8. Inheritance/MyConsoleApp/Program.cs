using System;

class Program
{
    static void Main()
    {
        Person[] people = new Person[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine()!;

            if (i < 2)
                people[i] = new Student(name);
            else
                people[i] = new Teacher(name);
        }

        foreach (Person person in people)
        {
            if (person is Student student)
            {
                student.Study();
            }
            else if (person is Teacher teacher)
            {
                teacher.Explain();
            }
        }
    }
}