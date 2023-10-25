public class Lecture : Event
{
    private int _maxCapacity;
    private string _speaker;

    public Lecture(string title, string description, DateTime date, Address addr, int max, string speaker) : base ("Outdoor", title, description, date, addr)
    {
        _maxCapacity = max;
        _speaker = speaker;

    }
    public override void DisplayFull()
    {
        Console.WriteLine($"{GetType()} Event");
        Display();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Max Capacity: {_maxCapacity}");
    }
}