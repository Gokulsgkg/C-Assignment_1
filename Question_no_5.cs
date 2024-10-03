using System;

class Patient
{
    private string name;
    private DateTime dateOfAdmission;
    private int age;
    private string disease;
    private DateTime dateOfDischarge;
    private decimal totalBillsPaid;

    public void GetPatientInfo()
    {
        Console.Write("Enter Patient Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Date of Admission (yyyy-mm-dd): ");
        dateOfAdmission = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter Age of Patient: ");
        age = int.Parse(Console.ReadLine());

        Console.Write("Enter Disease: ");
        disease = Console.ReadLine();

        Console.Write("Enter Date of Discharge (yyyy-mm-dd): ");
        dateOfDischarge = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter Total Bills Paid: ");
        totalBillsPaid = decimal.Parse(Console.ReadLine());
    }

    public void DisplayPatientInfo()
    {
        Console.WriteLine("\nPatient Details:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Date of Admission: {dateOfAdmission.ToShortDateString()}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Disease: {disease}");
        Console.WriteLine($"Date of Discharge: {dateOfDischarge.ToShortDateString()}");
        Console.WriteLine($"Total Bills Paid: {totalBillsPaid:C}");
    }
}

class Hospital
{
    static void Main(string[] args)
    {
        Patient patient = new Patient();
        patient.GetPatientInfo();
        patient.DisplayPatientInfo();
    }
}
