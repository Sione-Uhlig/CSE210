using System;

public abstract class Activity
{
    private string _date;
    private int _min;

    protected Activity(string date, int min)
    {
        _date = date;
        _min = min;

    }

    protected int GetMinutes()
    {
        return _min;
    }

    protected string GetDate()
    {
        return _date;
    }

    protected abstract double GetDistance();
    protected abstract double GetSpeed();
    protected abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"({GetMinutes()} min) - Distance {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, " +
               $"Pace: {GetPace():F2} min per mile";
    }
}