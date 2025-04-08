public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints, int timesCompleted = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _timesCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted == _targetCount)
        {
            Console.WriteLine("Checklist goal completed!");
            return _points + _bonusPoints;
        }
        else
        {
            return _points;
        }
    }

    public override string GetStatus()
    {
        string completed = _timesCompleted >= _targetCount ? "X" : " ";
        return $"[{completed}] {_name} ({_description}) -- Completed {_timesCompleted}/{_targetCount} times";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_timesCompleted}|{_targetCount}|{_bonusPoints}";
    }
}
