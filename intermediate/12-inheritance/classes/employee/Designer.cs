// using System;
namespace Inheritance;

class Designer : Employee
{
    public string DesignTool { get; }
    public Designer(string name, string department, string designTool) : base(name, department)
    {
        DesignTool = designTool;
    }

    public void ShowInfoDesigner()
    {
        Console.WriteLine(DesignTool);
    }
}