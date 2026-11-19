using System;
namespace Inheritance;
class Employee
{
    public string Name { get; }
    public string Departmen { get; }
    public Employee(string name, string department)
    {
        Name = name;
        Departmen = department;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{Name}, {Departmen}");
    }
}