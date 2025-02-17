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

    public abstract string GetSummary();

}