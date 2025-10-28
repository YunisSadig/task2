using System;
using System.Text.RegularExpressions;

class Employees
{
    public string Name { get; set; }
    public string Surname { get; set; }
    private double salary;

    public double Salary
    {
        get { return salary; }
        set
        {
            if (value < 250)
                throw new Exception("Salary cannot be less than 250.");
            salary = value;
        }
    }

    public Employees(string name, string surname, double salary)
    {
        
        if (!Regex.IsMatch(name, @"^[A-Z][a-zA-Z]*$"))
            throw new Exception("Name must start with a capital letter and contain only letters.");
        if (!Regex.IsMatch(surname, @"^[A-Z][a-zA-Z]*$"))
            throw new Exception("Surname must start with a capital letter and contain only letters.");

        Name = name;
        Surname = surname;
        Salary = salary; 
    }

    public override string ToString()
    {
        return $"{Name} {Surname}, Salary: {Salary}";
    }
}
