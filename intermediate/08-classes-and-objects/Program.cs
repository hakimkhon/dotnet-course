using MyApp;
internal class Program
{
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
    private static void Main(string[] args)
    {
        // ClassRoom.Task1();
        // ClassRoom.Task2();
        // ClassRoom.Task3();      
        // ClassRoom.Task4();      
        // ClassRoom.Task5();      

        HomeWork.Task2();


    }
}
