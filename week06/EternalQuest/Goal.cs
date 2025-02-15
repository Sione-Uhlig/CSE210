using System;

public abstract class Goal 
{
    public string _shortName;
    public string _description;
    public int _points;

    public Goal(string name, string desc, int points)
    {
        _shortName = name;
        _description = desc;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} - ({_description}) for {_points} points.";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{GetType().Name}|{_shortName}|{_description}|{_points}";
    }
}