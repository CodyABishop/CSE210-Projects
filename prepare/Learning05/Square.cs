public class Square : Shape
{
    private double _side;

    public Square(string col, double sid) : base (col)
    {
        _side = sid;
    }
    public override double GetArea()// Override used to specify inherited abstract method.
    {
        return Math.Pow(_side,2);
    }
}