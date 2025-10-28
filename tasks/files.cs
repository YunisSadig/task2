using System;

interface IWorkable { void Work(); }
interface IReportable { void GenerateReport(); }

abstract class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; protected set; }

    public Employee(string name, decimal salary) { Name = name; Salary = salary; }
    public abstract decimal CalculateSalary();
    public void GiveBonus(decimal amount) => Salary += amount;
}
class Developer : Employee, IWorkable, IReportable
{
    public int Projects { get; set; }
    private string report;

    public Developer(string name, decimal salary, int projects) : base(name, salary) { Projects = projects; }

    public override decimal CalculateSalary() => Salary = Salary + Projects * 200;
    public void Work() => Console.WriteLine($"Developer {Name} started working on {Projects} projects.");
    public void GenerateReport() { report = $"Completed {Projects} new modules."; Console.WriteLine($"{Name} generated a report: \"{report}\""); }
}

class Manager : Employee, IWorkable, IReportable
{
    public int TeamSize { get; set; }
    private string report;

    public Manager(string name, decimal salary, int teamSize) : base(name, salary) { TeamSize = teamSize; }

    public override decimal CalculateSalary() => Salary = Salary + TeamSize * 150;
    public void Work() => Console.WriteLine($"Manager {Name} managing {TeamSize} people.");
    public void GenerateReport() { report = "Team performance improved by 20%."; Console.WriteLine($"{Name} generated a report: \"{report}\""); }
}
class Intern : Employee, IWorkable, IReportable
{
    private string report;
    public Intern(string name, decimal salary) : base(name, salary) { }

    public override decimal CalculateSalary() => Salary;
    public void Work() => Console.WriteLine($"Intern {Name} is assisting the development team.");
    public void GenerateReport() { report = "Learned basics of C#."; Console.WriteLine($"{Name} generated a report: \"{report}\""); }
}
class Programs
{
    static void Main()
    {
        var dev = new Developer("Namiq", 4000, 3);
        var mgr = new Manager("Akif", 5000, 5);
        var intern = new Intern("Ali", 800);

        dev.Work(); dev.GenerateReport(); Console.WriteLine($"{dev.Name}'s salary: {dev.CalculateSalary()} AZN\n");
        mgr.Work(); mgr.GenerateReport(); Console.WriteLine($"{mgr.Name}'s salary: {mgr.CalculateSalary()} AZN\n");
        intern.Work(); intern.GenerateReport(); Console.WriteLine($"{intern.Name}'s salary: {intern.CalculateSalary()} AZN");
    }
}