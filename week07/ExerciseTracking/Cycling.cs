public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override string GetSummary()
    {
        double distance = _speed * _length / 60;    //km
        double pace = 60 / _speed;                  //min per km
        return $"{_date} Cycing ({_length} min): Distance {distance:F2} km, Speed: {_speed:F2} kph, Pace: {pace:F2} min per km";
    }
}