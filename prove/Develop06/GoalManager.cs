public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public int GetScore() { return _score; }

    public void CreateGoal()
    {
        Console.WriteLine("Which type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        if (choice == "1") 
        {
            newGoal = new SimpleGoal(name, desc, points);
        }
        else if (choice == "2") 
        {
            newGoal = new EternalGoal(name, desc, points);
        }
        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            newGoal = new ChecklistGoal(name, desc, points, 0, target, bonus);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return;
        }


        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

    public void ListGoals()
    {
        Console.WriteLine($"You have {_score} points.\n");
        int i = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{i}. {g.DisplayGoal()}");
            i++;
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the file name for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.Serialize());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            _goals.Add(Goal.Deserialize(lines[i]));
        }
        Console.WriteLine("Goals loaded successfully!");
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        if (choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        Goal g = _goals[choice - 1];
        g.RecordEvent(out int earnedPoints);
        _score += earnedPoints;
        Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
        Console.WriteLine($"You now have {_score} points.");
    }
}

