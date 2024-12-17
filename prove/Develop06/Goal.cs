

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    protected bool _isComplete;
    

    public Goal(string name, string description, int points, bool isComplete=false)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public string GetName() { return _shortName; }
    public string GetDescription() { return _description; }
    public int GetPoints() { return _points; }

    public virtual string DisplayGoal()
    {
        return $"{_shortName} ({_description})";
    }

    public abstract void RecordEvent(out int earnedPoints);
    public abstract bool IsComplete();

    public abstract string Serialize();

    public static Goal Deserialize(string line)
    {
        string[] parts = line.Split(":");
        string type = parts[0];
        string[] data = parts[1].Split(",");

        
        
        if (type == "SimpleGoal")
            return new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3]));
        else if (type == "EternalGoal")
            return new EternalGoal(data[0], data[1], int.Parse(data[2]));
        else if (type == "ChecklistGoal")
            return new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]), bool.Parse(data[6]));
        else
            throw new Exception("Unknown goal type");
    
    }
}

