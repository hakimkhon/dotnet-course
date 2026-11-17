using System;
namespace Homework11;

class StudySession
{
    private string _topic;
    private int _spentMinutes = 0;
    private int _plannedMinutes = 0;
    public string Topic => _topic;
    public int SpentMinutes => _spentMinutes;

    public StudySession(string topic, int plannedMinutes)
    {
        if (topic.Trim().Length != 0)
        {
            _topic = topic;
            this.PlannedMinutes = plannedMinutes;
        }
    }

    public int PlannedMinutes
    {
        get => _plannedMinutes;
        set
        {
            if (value is >= 10 and <= 120 && value >= _spentMinutes)
                _plannedMinutes = value;
        }
    }
    public bool RecordMinutes(int minutes)
    {
        if (minutes <= 0 || SpentMinutes + minutes > PlannedMinutes)
        {
            Console.Write("False; ");
            return false;
        }

        _spentMinutes += minutes;
        Console.Write("True; ");
        return true;
    }
    public int GetRemainingMinutes() => PlannedMinutes - SpentMinutes;
}