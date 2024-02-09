using System;
using System.Collections.Generic;


public class Employee
{
    public int EmployeeId { get; set; }
    public string EmployeeFirstName { get; set; }
    public string EmployeeLastName { get; set; }
    public int EmployeeAge { get; set; }
}

public class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        // Adding employees
        employees.Add(new Employee { EmployeeId = 1, EmployeeFirstName = "John", EmployeeLastName = "Doe", EmployeeAge = 30 });
        employees.Add(new Employee { EmployeeId = 2, EmployeeFirstName = "Jane", EmployeeLastName = "Smith", EmployeeAge = 25 });
        employees.Add(new Employee { EmployeeId = 3, EmployeeFirstName = "Mike", EmployeeLastName = "Johnson", EmployeeAge = 35 });

        // Displaying employees
        Console.WriteLine("Employees:");
        DisplayEmployees(employees);

        // Removing an employee (by EmployeeId)
        RemoveEmployeeById(employees, 2);

        // Displaying employees after removal
        Console.WriteLine("\nEmployees after removal:");
        DisplayEmployees(employees);
    }

    static void DisplayEmployees(List<Employee> employees)
    {
        foreach (var employee in employees)
        {
            Console.WriteLine($"EmployeeId: {employee.EmployeeId}, FirstName: {employee.EmployeeFirstName}, LastName: {employee.EmployeeLastName}, Age: {employee.EmployeeAge}");
        }
    }

    static void RemoveEmployeeById(List<Employee> employees, int employeeId)
    {
        Employee employeeToRemove = employees.Find(e => e.EmployeeId == employeeId)!;
        
        if (employeeToRemove != null)
        {
            employees.Remove(employeeToRemove);
            Console.WriteLine($"Employee with EmployeeId {employeeId} removed successfully.");
        }
        else
        {
            Console.WriteLine($"Employee with EmployeeId {employeeId} not found.");
        }
    }
}