using System;

public abstract class Goal 
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string desc, int points)
    {
        _shortName = name;
        _description = desc;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();

    public string GetDetailsString
}