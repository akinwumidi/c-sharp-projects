using System;

public class Goal
{
    protected internal string _shortName;
    protected internal string _description;
    protected internal int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public virtual bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public virtual string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}
