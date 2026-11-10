namespace MyApp;

class Student
{
    public string? FullName;
    public int Age;

    public void GetInfo()
    {
        Console.WriteLine($"{FullName}, {Age} yosh");
    }
}

class Book
{
    public string? Title;
    public string? Auther;
    public int PageCount;

    public void GetDescription()
    {
        System.Console.WriteLine($"{Title} - {Auther}, {PageCount} bet");
    }
}

class Rectangle
{
    public int Width;
    public int Height;
    public int GetArea() => Width * Height;
    public int GetPerimeter() => (Width + Height) * 2;
}

class Car
{
    string? Brand;
    private int _speed;
    public int Speed => _speed;
    public void Accelerate(int amount) => _speed += amount;
}

class Animal
{
    public string? Name;
    public string? Species;
    public string? Sound;
    public string Speak() => $"{Name} ({Species}): {Sound}";

}
public static class ClassRoom
{
    public static void Task1()
    {
        Console.WriteLine("==== ClassRoom Tasks 01 ===");
        Student madina = new();
        madina.FullName = "Madina Karimova";
        madina.Age = 18;

        Student ali = new() { FullName = "Ali Valiyev", Age = 24 };

        madina.GetInfo();
        ali.GetInfo();
    }
    public static void Task2()
    {
        Console.WriteLine("==== ClassRoom Tasks 02 ===");
        Book book_01 = new();
        {
            book_01.Title = "O‘tkan kunlar";
            book_01.Auther = "Abdulla Qodiriy";
            book_01.PageCount = 400;
        }

        var book_02 = new Book
        {
            Auther = book_01.Auther,
            Title = "Mehrobdan chayon",
            PageCount = 320
        };

        book_01.GetDescription();
        book_02.GetDescription();
    }
    public static void Task3()
    {
        Console.WriteLine("==== ClassRoom Tasks 03 ===");

        var shakl01 = new Rectangle { Width = 5, Height = 3 };
        Console.WriteLine($"1-Shakl eni={shakl01.Width}, bo'yi={shakl01.Height}  -> Yuza: {shakl01.GetArea()}, Perimetr: {shakl01.GetPerimeter()}");

        var shakl02 = new Rectangle { Width = 4, Height = 4 };
        Console.WriteLine($"2-Shakl eni={shakl02.Width}, bo'yi={shakl02.Height}  -> Yuza: {shakl02.GetArea()}, Perimetr: {shakl02.GetPerimeter()}");

        var shakl03 = new Rectangle { Width = 10, Height = 3 };
        Console.WriteLine($"2-Shakl eni={shakl03.Width}, bo'yi={shakl03.Height}  -> Yuza: {shakl03.GetArea()}, Perimetr: {shakl03.GetPerimeter()}");
    }
    public static void Task4()
    {
        Console.WriteLine("==== ClassRoom Tasks 04 ===");

        Car cobalt = new();
        Car malibu = new();

        Console.Write(cobalt.Speed + " ");
        Console.Write(malibu.Speed + " ");
        Console.WriteLine();

        cobalt.Accelerate(20);
        Console.Write(cobalt.Speed + " ");
        Console.Write(malibu.Speed + " ");
        Console.WriteLine();

        cobalt.Accelerate(10);
        Console.Write(cobalt.Speed + " ");
        Console.Write(malibu.Speed + " ");
        Console.WriteLine();

        malibu.Accelerate(40);
        Console.Write(cobalt.Speed + " ");
        Console.Write(malibu.Speed + " ");

    }
    public static void Task5()
    {
        Console.WriteLine("\n==== ClassRoom Tasks 04 ===");

        Animal cat = new();
        Animal dog = new();

        cat.Name = "Mosh";
        cat.Species = "Cat";
        cat.Sound = "Meow";
        Console.WriteLine(cat.Speak());

        dog.Name = "Rex";
        dog.Species = "Dog";
        dog.Sound = "Woof";
        Console.WriteLine(dog.Speak());

    }

}

