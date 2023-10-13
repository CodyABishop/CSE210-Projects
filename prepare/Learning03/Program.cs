using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Fraction frac1 = new Fraction();
        frac1.SetTop(3);
        frac1.SetBottom(5);
        Fraction frac2 = new Fraction(5);
        Fraction frac3 = new Fraction(3,7);

        Console.WriteLine("Fraction 1:" + frac1.GetFractionString() + " results in " + frac1.GetDecimalValue() +" via use of division of " + frac1.GetTop() + " and " +frac1.GetBottom());
        Console.WriteLine("Fraction 2:" + frac2.GetFractionString() + " results in " + frac2.GetDecimalValue() +" via use of division of " + frac2.GetTop() + " and " +frac2.GetBottom());
        Console.WriteLine("Fraction 3:" + frac3.GetFractionString() + " results in " + frac3.GetDecimalValue() +" via use of division of " + frac3.GetTop() + " and " +frac3.GetBottom());
    }
}

