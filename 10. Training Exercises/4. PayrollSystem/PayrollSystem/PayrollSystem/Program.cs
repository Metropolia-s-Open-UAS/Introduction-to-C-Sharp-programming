using System;
using System.Collections.Generic;
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public Employee(int id, string name, int salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }
}
class SalaryEmployee : Employee
{
    public int MonthlySalary;
    public SalaryEmployee(int id, string name, int Salary) : base(id, name, Salary)
    {
    }
    public SalaryEmployee(int id, string name, int Salary, int MonthlySalary) : base(id, name, Salary)
    {
        this.MonthlySalary = MonthlySalary;
    }
    public int CalculateSalary()
    {
        return MonthlySalary;
    }

}

class PayrollSystem
{
    public static void CalculatePayroll(Employee employee)
    {
        int Payroll = employee.Salary;
        Console.WriteLine("Employee Payroll");
        Console.WriteLine("================");
        Console.WriteLine($"Payroll for: {employee.Id} - {employee.Name}");
        Console.WriteLine($"- Check amount: {employee.Salary}");
        Console.WriteLine();

    }
}

class Program
{
    public static void Main(string[] args)
    {
        int id = 0;
        List<Employee> employees = new List<Employee>();
        List<SalaryEmployee> salaryEmployees = new List<SalaryEmployee>();
        while (true)
        {
            Console.Write("Please enter employee name (0 to quit): ");
            var Answer = Convert.ToString(Console.ReadLine());

            if (Answer == "0")
            {
                break;
            }
            else if (Answer == null)
            {
                Console.WriteLine("Please enter Valid Name");
            }
            else
            {
                id++;
                Console.Write("Please enter salary: ");
                var Salary = Convert.ToInt32(Console.ReadLine());
                salaryEmployees.Add(new SalaryEmployee(id, Answer, Salary));
            }
        }

        foreach (var emp in salaryEmployees)
        {
            PayrollSystem.CalculatePayroll(emp);
        }
    }
}
