using System;
public class Swimming : Activity
{
    private int _laps;
    private const double _lapLengthMiles = 0.031;  

    public Swimming(string date, int min, int laps) : base(date, min)
    {
        _laps = laps;
    }
    
     protected override double GetDistance()
    {
        return _laps * _lapLengthMiles;
    }

     protected override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

     protected override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming {base.GetSummary()}\n";
    }
}