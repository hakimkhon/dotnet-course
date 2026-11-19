using System;
namespace Inheritance;

class Developer : Employee
{
    public string ProgrammingLanguage { get; }
    public Developer(string name, string department, string programmingLanguage) : base(name, department)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    public void ShowInfoDeveloper()
    {
        Console.WriteLine(ProgrammingLanguage);
    }
}