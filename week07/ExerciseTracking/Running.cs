using System; 

public class Running : Activity
{
    private double _distance;

    public Running(string date, int min, double distance) : base(date, min)
    {
        _distance = distance;
    
    }
    

    protected override double GetDistance()
    {
        return _distance;
    }

    protected override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }

    protected override double GetPace()
    {
        return GetMinutes() / GetDistance(); 
    }

    public override string GetSummary()
    {
        return $"\n{GetDate()} Running {base.GetSummary()}";
    }
}