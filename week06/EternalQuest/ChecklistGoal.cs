public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"You completed: {_amountCompleted}/{_target} for {_shortName}");
        if (IsComplete())
        {
            Console.WriteLine($"Congratulations! You have completed {_shortName} and earned {_bonus} bonus points.");
        }
        else
        {
            Console.WriteLine($"You have earned {_points} points.");
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public override string GetDetailsString()
    {
        return $"--- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName}({_description})";
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }
    public int GetTarget()
    {
        return _target;
    }
    public int GetBonus()
    {
        return _bonus;
    }
}