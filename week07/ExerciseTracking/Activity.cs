public abstract class Activity
{
    protected string _date;
    protected double _length;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }
    public string GetDate()
    {
        return _date;
    }

    public double GetLength()
    {
        return _length;
    }
    public abstract string GetSummary();

}