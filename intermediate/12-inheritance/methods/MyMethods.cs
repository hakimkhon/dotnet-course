namespace Inheritance;

class MyMethods
{
    public void PersonTask()
    {
        var student = new Student(name: "Ali", course: "C#");
        student.Introduce();
    }
    public void EmployeeTask()
    {
        var devoloper = new Developer("Malika", "IT", "C#");
        devoloper.ShowInfo();
        // devoloper.ShowInfoDeveloper();

        var designer = new Designer("Jasur", "Design", "Figma");
        designer.ShowInfo();
        // designer.ShowInfoDeveloper();

    }
}
