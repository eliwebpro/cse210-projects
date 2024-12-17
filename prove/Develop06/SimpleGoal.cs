public class SimpleGoal : Goal
{
    // private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete=false) : base(name, description, points, isComplete)
    {
    }

    public override bool IsComplete() => _isComplete;

    public override void RecordEvent(out int earnedPoints)
    {
        if (!_isComplete)
        {
            _isComplete = true;
            earnedPoints = _points;
        }
        else
        {
            earnedPoints = 0; 
        }
    }

    public override string DisplayGoal()
    {
        string check = IsComplete() ? "[X]" : "[ ]";
        return $"{check} {base.DisplayGoal()}";
    }

    public override string Serialize()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}

