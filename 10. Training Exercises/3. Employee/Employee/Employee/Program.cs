using System;
using System.Collections.Generic;

public class Employee
{
    public string Name;
    public int Id;

    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        int id = 0;
        while (true)
        {
            Console.Write("Please enter employee name (0 to quit):");
            var name = Convert.ToString(Console.ReadLine());

            if (name == "0")
            {
                break;
            }
            else if (name == null)
            {
                Console.WriteLine("Please enter a valid name");
            }
            else
            {
                id++;
                employees.Add(new Employee(name, id));
            }

        }
        foreach (var employee in employees)
        {
            Console.WriteLine($"Id: {employee.Id} Name: {employee.Name}");
        }
    }
}