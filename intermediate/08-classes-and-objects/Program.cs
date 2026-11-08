internal class Program
{
    class Student
    {
        public string? FullName;
        public int Age;

        public void GetInfo()
        {
            Console.WriteLine(
                $"""
                    FullName: {FullName}
                    Age: {Age}
                """
            );
        }
    }

    private static void Main(string[] args)
    {
        Student madina = new();
        madina.FullName = "Madina";
        madina.Age = 18;

        Console.WriteLine("++++++++++++++++");
        
        Student ali = new() { FullName = "Ali", Age = 24 };
        ali.GetInfo();
        madina.GetInfo();
    }
}
