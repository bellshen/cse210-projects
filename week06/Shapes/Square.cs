using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

public class Square: Shape
{
    private double _side;
    public Square(string color, double side):base(color)
    {
        _color = color;
        _side = side;

    }
    public override double GetArea()
    {
        return _side * _side;
    }
}