using System;
using System.Text.RegularExpressions;

class Validation
{
    static void Main()
    {
        Console.Write("Enter the mobile number: ");
        string mobileNumber = Console.ReadLine();

        if (IsValidMobileNumber(mobileNumber))
        {
            Console.WriteLine("The mobile number is valid.");
        }
        else
        {
            Console.WriteLine("The mobile number is invalid.");
        }
    }

    static bool IsValidMobileNumber(string mobileNumber)
    {
        string pattern = @"^[98][0-9]{3}-[0-9]{6}$";
        return Regex.IsMatch(mobileNumber, pattern);
    }
}
