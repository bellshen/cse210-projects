public class Running: Activity
{
    private double _distance;

    public Running(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }
    
    public override string GetSummary()
    {
        double speed = _distance / _length * 60;   //km per hour
        double pace = _length / _distance;         //min per km
        return $"{_date} Running ({_length} min): Distance {_distance:F2} km, Speed: {speed:F2} kph, Pace: {pace:F2} min per km";
    }

}