using System;
using System.Web;
public class CitizenProfile
{
    public string FullName { get; set; }
    public int IDNumber { get; set; }
    public int Age { get; set; }
    public string CitizenshipStatus { get; set; }

    public CitizenProfile(string name, int id, int age, string status)
    {
        FullName = name;
        IDNumber = id;
        Age = age;
        CitizenshipStatus = status;
    }

    private int CalculateAge()
    {
        int year = int.Parse(IDNumber.Substring(0, 2));
        int month = int.Parse(IDNumber.Substring(2, 2));
        int day = int.Parse(IDNumber.Substring(4, 2));
        
        int fullYear = (year > 25) ? 1900 + year : 2000 + year; // Assuming current year is 2025
        DateTime birthDate = new DateTime(fullYear, month, day);
        int age = DateTime.Now.Year - birthDate.Year;

        return age;
    }

    public string ValidateID()
    {
        if (IDNumber.Length != 13)
            return "Invalid ID Number: Must be 13 digits long.";

        if (!long.TryParse(IDNumber, out _))
            return "Invalid ID Number: Must contain only digits.";

        return "Valid ID Number.";
    }

}