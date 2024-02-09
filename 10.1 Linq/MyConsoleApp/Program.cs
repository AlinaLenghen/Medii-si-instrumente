using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person { PersonId = 1, FirstName = "John", LastName = "Doe", Age = 25, RoleId = 1 },
            new Person { PersonId = 2, FirstName = "Jane", LastName = "Smith", Age = 30, RoleId = 2 },
            new Person { PersonId = 3, FirstName = "Mike", LastName = "Johnson", Age = 20, RoleId = 1 },
            new Person { PersonId = 4, FirstName = "Emily", LastName = "Jones", Age = 35, RoleId = 3 },
            new Person { PersonId = 5, FirstName = "Alex", LastName = "Brown", Age = 40, RoleId = 2 }
        };

        List<Role> roles = new List<Role>
        {
            new Role { RoleId = 1, RoleDescription = "Manager" },
            new Role { RoleId = 2, RoleDescription = "Employee" },
            new Role { RoleId = 3, RoleDescription = "Director" }
        };

        var peopleOver18 = people.Where(p => p.Age > 18);
        Console.WriteLine("People with age > 18:");
        foreach (var person in peopleOver18)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }

        var allPersonNames = people.Select(p => $"{p.FirstName} {p.LastName}");
        Console.WriteLine("\nAll person's names:");
        foreach (var name in allPersonNames)
        {
            Console.WriteLine(name);
        }

        var peopleWithRoleId1 = people.Where(p => p.RoleId == 1);
        Console.WriteLine("\nPeople with RoleId=1:");
        foreach (var person in peopleWithRoleId1)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }

        var firstTwoYoungestPeople = people.OrderBy(p => p.Age).Take(2);
        Console.WriteLine("\nFirst two youngest people:");
        foreach (var person in firstTwoYoungestPeople)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }

        var allButMostTwoYoungestPeople = people.OrderByDescending(p => p.Age).Skip(2);
        Console.WriteLine("\nAll but most two youngest people:");
        foreach (var person in allButMostTwoYoungestPeople)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }

        var peopleWithRole = from person in people
                             join role in roles on person.RoleId equals role.RoleId
                             select new { person.FirstName, person.LastName, RoleDescription = role.RoleDescription };
        Console.WriteLine("\nPeople with their role:");
        foreach (var item in peopleWithRole)
        {
            Console.WriteLine($"{item.FirstName} {item.LastName} - {item.RoleDescription}");
        }

        var peopleOrderedByAgeDesc = people.OrderByDescending(p => p.Age);
        Console.WriteLine("\nList of people ordered by age descending:");
        foreach (var person in peopleOrderedByAgeDesc)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName} - Age: {person.Age}");
        }

        var peopleGroupedByRole = from person in people
                                  join role in roles on person.RoleId equals role.RoleId
                                  group person by role.RoleDescription into g
                                  select new { Role = g.Key, People = g.ToList() };
        Console.WriteLine("\nList of people grouped by role:");
        foreach (var group in peopleGroupedByRole)
        {
            Console.WriteLine($"{group.Role}:");
            foreach (var person in group.People)
            {
                Console.WriteLine($"- {person.FirstName} {person.LastName}");
            }
        }

        var personWithFirstName1 = people.FirstOrDefault(p => p.FirstName == "John");
        if (personWithFirstName1 != null)
        {
            Console.WriteLine($"\nPerson with first name 'John' found: {personWithFirstName1.FirstName} {personWithFirstName1.LastName}");
        }
        else
        {
            Console.WriteLine("Person with first name 'John' not found.");
        }

        var totalLeaders = people.Count(p => roles.Any(r => r.RoleId == p.RoleId && r.RoleDescription == "Manager"));
        Console.WriteLine($"\nTotal of people with role 'Manager': {totalLeaders}");

        var hasBA = people.Any(p => p.FirstName.Contains("BA") || p.LastName.Contains("BA"));
        Console.WriteLine($"\nDoes any person have 'BA' in first name or last name? {hasBA}");

        var personWithAge60 = people.FirstOrDefault(p => p.Age == 60);
        if (personWithAge60 != null)
        {
            Console.WriteLine($"\nFirst person with age 60 found: {personWithAge60.FirstName} {personWithAge60.LastName}");
        }
        else
        {
            Console.WriteLine("No person with age 60 found.");
        }
    }
}