class Program
{
    static void Main(string[] args)
    {
        //Create an assignment of each type.
        Assignment a1 = new Assignment("Alice Himura", "Linear Algebra");
        MathAssignment a2 = new MathAssignment("Avyranna Lycora", "Synthetic Division", "13.37", "4-20");
        WritingAssignment a3 = new WritingAssignment("Melody Vauss", "Introduction to Poetry", "Flowery Metaphors");
        //Print Base assignment
        Console.WriteLine(a1.GetSummary());
        //Print Math Assignment
        Console.WriteLine(a2.GetSummary()); //Get summary works because it's inherited from the parent class
        Console.WriteLine(a2.GetHomeworkList());    
        //Print Writing Assignment    
        Console.WriteLine(a3.GetSummary()); //Get summary works because it's inherited from the parent class
        Console.WriteLine(a3.GetWritingInformation());
    }
}
