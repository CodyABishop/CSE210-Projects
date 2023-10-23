public class Circle : Shape
{
    private double _radius;

    public Circle(string col, double rad) : base (col)
    {
        _radius = rad;
    }
    public override double GetArea()// Override used to specify inherited abstract method.
    {
        return Math.Pow(_radius,2) * Math.PI;
    }
}