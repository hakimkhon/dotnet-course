namespace Inheritance;

class Person
{
    public string Name { get; }
    public Person(string name)
    {
        Name = name;
    }
    public void Introduce()
    {
         Console.WriteLine($"Salom, men {Name}");   
    }
}