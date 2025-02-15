using System;

public class ChecklistGoal : Goal
{
    public int _amountCompleted;
    public int _target;
    public int _bonus;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus) : base(name, desc, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} With a bonus of {_bonus} points when completed -- Completed {_amountCompleted}/{_target} times.";
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()}|{_amountCompleted}|{_target}|{_bonus}";
    }
}