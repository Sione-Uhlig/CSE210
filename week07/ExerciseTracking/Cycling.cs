using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int min, double speed) : base(date, min)
    {
        _speed = speed;
    }

    private double GetDistance()
    {
        return (_speed * GetMinutes()) / 60;
    }

    private double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
       return $"{GetDate()} Cycling ({GetMinutes()} min) - Distance {GetDistance():F1} miles, Speed: {_speed:F1} mph, " +
        $"Pace: {GetPace():F2} min per mile";
    }
}


