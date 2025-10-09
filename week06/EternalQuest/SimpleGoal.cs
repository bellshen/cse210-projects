public class SimpleGoal:Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"You have completed {_shortName} and earned {_points} points.");
        }
        else
        {
            Console.WriteLine($"{_shortName} is already completed.");
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
     public void SetIsComplete(bool complete)
    {
        _isComplete = complete;
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName} ({_description})";
    }
}