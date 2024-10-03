using System;

class Student
{
    protected string name;
    protected int age;
    protected string address;
    protected string mobileNumber;

    public virtual void getData()
    {
        Console.Write("Enter Student Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Age: ");
        age = int.Parse(Console.ReadLine());

        Console.Write("Enter Address: ");
        address = Console.ReadLine();

        Console.Write("Enter Mobile Number: ");
        mobileNumber = Console.ReadLine();
    }

    public virtual void printData()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Address: {address}");
        Console.WriteLine($"Mobile Number: {mobileNumber}");
    }
}

class StudentMark : Student
{
    private int marks;

    public override void getData()
    {
        base.getData();
        Console.Write("Enter Marks: ");
        marks = int.Parse(Console.ReadLine());
    }

    public override void printData()
    {
        base.printData();
        Console.WriteLine($"Marks: {marks}");
        Console.WriteLine($"Grade: {FindGrade()}");
    }

    private string FindGrade()
    {
        if (marks >= 90) return "A";
        else if (marks >= 75) return "B";
        else if (marks >= 60) return "C";
        else if (marks >= 50) return "D";
        else return "F";
    }
}

class StudentMain
{
    static void Main(string[] args)
    {
        StudentMark studentMark = new StudentMark();
        studentMark.getData();
        studentMark.printData();
    }
}
