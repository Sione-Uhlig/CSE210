using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points) : base(name, desc, points)
    {

    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
}