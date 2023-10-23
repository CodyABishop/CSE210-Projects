public class Rectangle : Shape
{
    private double _length; //Requires 2 variables for area storage
    private double _width;
    public Rectangle(string col, double le, double wi) : base (col)
    {
        _length = le;
        _width = wi;
    }
    public override double GetArea()// Override used to specify inherited abstract method.
    {
        return _length * _width;
    }
}