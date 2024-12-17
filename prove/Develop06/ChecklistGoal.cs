public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    // private bool _isComplete;

    public ChecklistGoal(string name, string description, int points, int currentCount, int targetCount, int bonus, bool isComplete=false)
        : base(name, description, points, isComplete)
    {
        _amountCompleted = currentCount;
        _target = targetCount;
        _bonus = bonus;
    }

    public override bool IsComplete() => _isComplete;

    public override void RecordEvent(out int earnedPoints)
    {
        if (!_isComplete)
        {
            _amountCompleted++;
            earnedPoints = _points;
            if (_amountCompleted >= _target)
            {
                _isComplete = true;
                earnedPoints += _bonus;
            }
        }
        else
        {
            earnedPoints = 0; // Already complete
        }
    }

    public override string DisplayGoal()
    {
        string check = IsComplete() ? "[X]" : "[ ]";
        return $"{check} {base.DisplayGoal()} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus},{_isComplete}";
    }
}

