namespace MyApp;
using System;
class MyMethods
{
    public void Task1()
    {
        var svetafor1 = new TrafficLight();
        svetafor1.GetColor();
        svetafor1.NextColor();
        svetafor1.NextColor();
        svetafor1.NextColor();
        svetafor1.NextColor();
        
        var svetafor2 = new TrafficLight();
        svetafor2.GetColor();
    }

    public void Task2()
    {
        var hamyon_01 = new Wallet();
        // var hamyon_02 = new Wallet();

        hamyon_01.AddMoney(50000);
        Console.WriteLine($" {hamyon_01.GetBalance()}");

        Console.WriteLine(hamyon_01.SpendMoney(12000));
        Console.WriteLine($" {hamyon_01.GetBalance()}");

        Console.WriteLine(hamyon_01.SpendMoney(40000));
        Console.WriteLine($" {hamyon_01.GetBalance()}");
    }
}