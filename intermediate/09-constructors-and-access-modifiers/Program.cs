using System;
internal class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Thermostat    // ammo ularni saqlaydigan fieldlar private bo‘lsin.    
{
    bool SetTarget(int temperature) => (16 <= temperature && temperature >= 30) ? true : false;
    void AdjustOneDegree()
    {
        
    }
    string GetStatus(){}

    public Thermostat(string roomName, int initialTemperature, int targetTemperature)
    {


    }

}