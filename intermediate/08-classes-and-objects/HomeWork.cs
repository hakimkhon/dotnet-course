namespace MyApp;

class TrafficLight
{
    string Color = "Red";
    string[] colors = ["Red", "Yellow", "Green"];
    void NextColor()
    {

    }
    void GetColor()
    {
        Console.WriteLine(Color);
    }
} 

public static class HomeWork
{
    public static void Task1()
    {
        Console.WriteLine("Homework 1: ikki son yig'indisi");
        int a = 5, b = 7;
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    public static int Square(int x) => x * x;
}