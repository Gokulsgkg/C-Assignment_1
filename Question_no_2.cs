using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Aravind's age: ");
        int age = int.Parse(Console.ReadLine());
        
        Console.Write("Enter Aravind's 10th standard pass percentage: ");
        double passPercentage = double.Parse(Console.ReadLine());

        bool isEligible = (age > 18 && age <= 30) && (passPercentage >= 65);

        if (isEligible)
        {
            Console.WriteLine("Aravind is eligible to apply for the competitive exam.");
        }
        else
        {
            Console.WriteLine("Aravind is not eligible to apply for the competitive exam.");
        }
    }
}
