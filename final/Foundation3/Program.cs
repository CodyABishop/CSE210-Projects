using System;

class Program
{
    static void Main(string[] args)
    {   
        DateTime lecDate = DateTime.Parse("11/4/2023 12:15:12 PM");
        Address lecAddr = new("1212 Binglette Ln","San Francisco", "CA");
        Lecture lecEvent = new("A Proposal of Fusion plausibility", "A scientific lecture on the feasibility of nuclear fusion-based power", lecDate, lecAddr, 101, "Dr. Brite");
        //Reception Event
        DateTime recDate = DateTime.Parse("12/9/2023 5:13:22 PM");
        Address recAddr = new("1212 Bongo Dr","Somewhere", "NY");
        Reception recEvent = new("Fusion Celebration", "A reception to welcome the group working on the new fusion reactor.", recDate, recAddr, "trustyReactors@fusion.pow");
        //Outdoor Event
        DateTime outDate = DateTime.Parse("1/14/2024 8:15:12 AM");
        Address outAddr = new("4747 Cat's Run Drive","Nasheville", "TN");
        Outdoor outEvent = new("A Proposal of Fusion plausibility", "A scientific lecture on the feasibility of nuclear fusion-based power", outDate, outAddr, "Low 40's, Light snowfall");
        //Begin marketing reports
        Console.WriteLine("Lecture Event Marketing Output");
        Console.WriteLine("--Short--");
        lecEvent.DisplayShort();
        Console.WriteLine("--Main--");
        lecEvent.Display();
        Console.WriteLine("--Full--");
        lecEvent.DisplayFull();
        Console.WriteLine("Reception Event Marketing Output");
        Console.WriteLine("--Short--");
        recEvent.DisplayShort();
        Console.WriteLine("--Main--");
        recEvent.Display();
        Console.WriteLine("--Full--");
        recEvent.DisplayFull();
        Console.WriteLine("Outdoor Event Marketing Output");
        Console.WriteLine("--Short--");
        outEvent.DisplayShort();
        Console.WriteLine("--Main--");
        outEvent.Display();
        Console.WriteLine("--Full--");
        outEvent.DisplayFull();
    }
}