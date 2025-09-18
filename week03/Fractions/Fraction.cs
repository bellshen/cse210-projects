public class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction()
    {
        //initializes the number to 1/1
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        //initializes the denominator to 1
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
    
}