using System;

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
                salary = 250;
            else
                salary = value;
        }
    }

    public Employees(string name, string surname, double salary)
    {
        
        Name = name;
        Surname = surname;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"{Name} {Surname}, Salary: {Salary}";
    }
}


class Program
{
    static void Main()
    {
        Employees emp1 = new Employees("Namiq", "Jabbarov", 400);
        Employees emp2 = new Employees("ali", "veli", 200); 

        Console.WriteLine(emp1);
        Console.WriteLine(emp2);
    }
}

