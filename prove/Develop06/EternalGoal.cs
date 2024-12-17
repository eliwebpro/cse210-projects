public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override bool IsComplete() => false;

    public override void RecordEvent(out int earnedPoints)
    {
        earnedPoints = _points; 
    }

    public override string DisplayGoal()
    {
        return $"[ ] {base.DisplayGoal()} (eternal)";
    }

    public override string Serialize()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}

