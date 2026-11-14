namespace HomeWork;

class Thermostat
{
    public string RoomName;
    public int InitialTemperature;
    public int TargetTemperature;
    readonly int minTemperatura = 16;
    const int maxTemperatura = 30;

    public Thermostat(string roomName, int initialTemperature, int targetTemperature)
    {
        this.RoomName = roomName;
        this.InitialTemperature = initialTemperature;
        this.TargetTemperature = targetTemperature;
    }

    public bool SetTarget(int temperature)
    {
        if (minTemperatura <= temperature && temperature <= maxTemperatura)
        {
            this.TargetTemperature = temperature;
            return true;
        }

        return false;
    }

    public void AdjustOneDegree()
    {
        if (this.InitialTemperature < this.TargetTemperature)
            InitialTemperature++;
        else if (this.InitialTemperature > this.TargetTemperature)
            InitialTemperature--;
    }

    public string GetStatus()
    {
        if (this.InitialTemperature < this.TargetTemperature)
            return $"{this.InitialTemperature}; maqsad {this.TargetTemperature}; holat, Heating";
        else if (this.InitialTemperature > this.TargetTemperature)
            return $"{this.InitialTemperature}; maqsad {this.TargetTemperature}; holat, Cooling";
        return $"{this.InitialTemperature}; maqsad {this.TargetTemperature}; holat, At target";
    }
}
