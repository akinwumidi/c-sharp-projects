using System;

public class ChecklistGoal : Goal
{
    private int _completedCount;
    private int _requiredCount;

    public ChecklistGoal(string shortName, string description, int points, int requiredCount) : base(shortName, description, points)
    {
        _completedCount = 0;
        _requiredCount = requiredCount;
    }

    public override void RecordEvent()
    {
        _completedCount++;
    }

    public override bool IsComplete()
    {
        return _completedCount >= _requiredCount;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}: {_description} - {_points} points (Completed {_completedCount}/{_requiredCount} times)";
    }
}
