public class Swimming : Activity
{
    private double _lapNumber;

    public Swimming(string date, double length, double lapNumber) : base(date, length)
    {
        _lapNumber = lapNumber;
    }
    public override string GetSummary()
    {
        double distance = _lapNumber * 50 / 1000;   //km
        double speed = distance / _length * 60;     //km per hour
        double pace = _length / distance;           //min per km
        
        return $"{_date} Swimming ({_length} min): Distance {distance:F2} km, Speed: {speed:F2} kph, Pace: {pace:F2} min per km";
    }
}