namespace Inheritance;

class Student : Person
{
    public string Course { get; }

    public Student(string name, string course) : base(name)
    {
        Course = course;        
    }
}