class Program
{
    static void Main(string[] args)
    {
        // By polymorphism, the list can contain Shape and all objects inheriting from Shape
        //Using a List rather than Array because Array's can't be resized
        List<Shape> shapes = new List<Shape>();
        //Instantiate each shape
        Square sq1 = new Square("Pink", 2.2);
        Circle cir1 = new Circle("Maroon", 7.4);
        Rectangle rect1 = new Rectangle("Cyan", .5, 4);
        //Add each shape to list
        shapes.Add(sq1);
        shapes.Add(cir1);
        shapes.Add(rect1);
        foreach (Shape s in shapes)
        {
            // Inherited methods
            string c = s.GetColor();
            double a = s.GetArea();
            Console.WriteLine($"The shape that's {c} has an area: {a}.");
        }
    }
}