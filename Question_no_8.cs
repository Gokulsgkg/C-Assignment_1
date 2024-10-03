using System;

class Employee
{
    private int empno;
    private string empname;
    private int job_catg;
    private decimal basic;
    private decimal hra;
    private decimal da;
    private decimal pf;
    private decimal loan;
    private decimal netSalary;

    public void Input()
    {
        Console.Write("Enter Employee Number: ");
        empno = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        empname = Console.ReadLine();

        Console.Write("Enter Job Category (1 for Table-I, 2 for Table-II): ");
        job_catg = int.Parse(Console.ReadLine());
    }

    public void CalculateSalary()
    {
        if (job_catg == 1)
        {
            basic = 80000;
            hra = 0.10m * basic;
            da = 0.20m * basic;
            loan = 300;
            pf = 500;
        }
        else if (job_catg == 2)
        {
            basic = 150000;
            hra = 0.20m * basic;
            da = 0.30m * basic;
            loan = 600;
            pf = 1000;
        }
        else
        {
            Console.WriteLine("Invalid Job Category!");
            return;
        }

        netSalary = basic + hra + da - (pf + loan);
    }

    public void Display()
    {
        Console.WriteLine($"Employee Number: {empno}");
        Console.WriteLine($"Employee Name: {empname}");
        Console.WriteLine($"Job Category: {job_catg}");
        Console.WriteLine($"Basic Salary: Rs. {basic}");
        Console.WriteLine($"HRA: Rs. {hra}");
        Console.WriteLine($"DA: Rs. {da}");
        Console.WriteLine($"Loan Deduction: Rs. {loan}");
        Console.WriteLine($"PF Deduction: Rs. {pf}");
        Console.WriteLine($"Net Salary: Rs. {netSalary}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.Input();
        employee.CalculateSalary();
        employee.Display();
    }
}
