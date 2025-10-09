public class EternalGoal:Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You have completed '{_shortName}' and earned {_points} points!");
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName} ({_description})";   
    }
}