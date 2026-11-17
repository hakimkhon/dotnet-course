namespace Homework11;

using System;

class WaterTank
{
    private int _capacity;
    private int _water;
    public int Capacity => _capacity;
    public int Water => _water;

    public WaterTank(int capasity, int initialWater)
    {
        if (0 < capasity && initialWater < capasity)
        {
            _capacity = capasity;
            _water = initialWater;
        }
    }

    public bool Fill(int amount)
    {
        if (0 < amount && amount <= GetFreeCapacity())
        {
            _water += amount;
            Console.Write("True; ");
            return true;
        }

        Console.Write("False; ");
        return false;
    }

    public bool Use(int amount)
    {
        if (0 < amount && amount <= _water)
        {
            _water -= amount;
            Console.Write("True; ");
            return true;
        }

        Console.Write($"False; ");
        return false;
    }

    public int GetFreeCapacity() => Capacity - Water;
}
