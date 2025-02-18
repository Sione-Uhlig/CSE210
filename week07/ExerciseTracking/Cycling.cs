using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int min, double speed) : base(date, min)
    {
        _speed = speed;
    }
     protected override double GetSpeed()
    {
        return _speed;
    }

    protected override double GetDistance()
    {
        return (GetSpeed() * GetMinutes()) / 60;
    }

    

    protected override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
       return $"{GetDate()} Cycling {base.GetSummary()}";
    }
}


