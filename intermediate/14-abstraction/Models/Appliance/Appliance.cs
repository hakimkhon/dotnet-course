namespace Abstraction.Models;

public abstract class Appliance
{
    public abstract string Name { get; }
    public abstract void CalculatePowerConsumption(int hours);
}

public class WashingMachine : Appliance
{
    private string v;

    public WashingMachine(string v)
    {
        this.v = v;
    }

    public override string Name => "Kir yuvish mashinasi";

    public override void CalculatePowerConsumption(int hours)
    {
        Console.WriteLine($"{hours * 3} kVt");
    }
}

public class AirHeater : Appliance
{
    private string v;

    public AirHeater(string v)
    {
        this.v = v;
    }

    public override string Name => "Isitgich";

    public override void CalculatePowerConsumption(int hours)
    {
        Console.WriteLine($"{hours * 3} kVt");
    }
}

public class ElectricKettle : Appliance
{
    public ElectricKettle(string v)
    {
        V = v;
    }

    public override string Name => "Choynak";

    public string V { get; }

    public override void CalculatePowerConsumption(int hours)
    {
        Console.WriteLine($"{hours * 3} kVt");
    }
}
