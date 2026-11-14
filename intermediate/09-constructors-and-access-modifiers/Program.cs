using HomeWork;

internal class Program
{
    private static void Main(string[] args)
    {
        ThermostatTask_1();
        PlaylistTask_2();
        LibraryTask_3();
        CourceTask_04();
    }

    static void ThermostatTask_1()
    {
        var livingRoom = new Thermostat("Living room", 20, 23);
        var bedroom = new Thermostat("Bedroom", 24, 21);
        var office = new Thermostat("Office", 19, 19);

        livingRoom.AdjustOneDegree();
        livingRoom.AdjustOneDegree();
        bedroom.AdjustOneDegree();

        Console.WriteLine(livingRoom.GetStatus());
        Console.WriteLine(bedroom.GetStatus());
        Console.WriteLine(office.GetStatus());

        bool result = livingRoom.SetTarget(31);
        Console.WriteLine($"{result}; maqsad {livingRoom.TargetTemperature} bo‘lib qoladi");
    }

    static void PlaylistTask_2()
    {
        
    }
    static void LibraryTask_3()
    {
        Book book1 = new Book("B01", "CSharp Basics", 2);
        Book book2 = new Book("B02", "OOP Guide", 1);
        Book book3 = new Book("B03", "LINQ Handbook", 3);

        Library library = new Library(4);

        Console.WriteLine($"B01 qo'shildi: {library.AddBook(book1)}");
        Console.WriteLine($"B02 qo'shildi: {library.AddBook(book2)}");
        Console.WriteLine($"B03 qo'shildi: {library.AddBook(book3)}");
        Console.WriteLine($"B01 takroran qo'shildi: {library.AddBook(book1)}");

        Console.WriteLine($"B01 olindi: {library.BorrowBook("B01")}");
        Console.WriteLine($"B01 olindi: {library.BorrowBook("B01")}");
        Console.WriteLine($"B01 mavjud nusxa: {book1.Count}");

        Console.WriteLine($"B02 olindi: {library.BorrowBook("B02")}");
        Console.WriteLine($"B02 yana olindi: {library.BorrowBook("B02")}");
        Console.WriteLine($"B02 mavjud nusxa: {book2.Count}");

        Console.WriteLine($"B03 olindi: {library.BorrowBook("B03")}");
        Console.WriteLine($"B03 mavjud nusxa: {book3.Count}");
        Console.WriteLine($"B99 olindi: {library.BorrowBook("B99")}");

        Console.WriteLine($"B01 qaytarildi: {library.ReturnBorrow("B01")}");
        Console.WriteLine($"B02 qaytarildi: {library.ReturnBorrow("B02")}");

        Console.WriteLine($"Mavjud kitob nusxalari jami: {library.GetAvailableCopies()}");
        Console.WriteLine("Mavjud bo'lmagan kitoblar:");
        library.PrintUnavailableBooks();

        Library emptyLibrary = new Library(4);
        Console.WriteLine($"Bo'sh kutubxonaning nusxalari: {emptyLibrary.GetAvailableCopies()}");
    }

    static void CourceTask_04()
    {
        var course_01 = new Course();
        var course_02 = new Course("OOP");
        var course_03 = new Course("LINQ", 8);
        var course_04 = new Course("   ");
        var course_05 = new Course("OOP", 0);
    }
}
