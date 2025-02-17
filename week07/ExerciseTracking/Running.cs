using System; 

public class Running : Activity
{
    private double _distance;

    public Running(string date, int min, double distance) : base(date, min)
    {
        _distance = distance;
    
    }

    private double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }

    private double GetPace()
    {
        return GetMinutes() / _distance; 
    }

    public override string GetSummary()
    {
        return $"\n{GetDate()} Running ({GetMinutes()} min) - Distance {_distance:F1} miles, Speed: {GetSpeed():F1} mph, " +
        $"Pace: {GetPace():F2} min per mile";
    }
}