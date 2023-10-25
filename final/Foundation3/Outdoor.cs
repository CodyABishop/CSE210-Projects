public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, DateTime date, Address addr, string weather) : base ("Outdoor", title, description, date, addr)
    {
        _weather = weather;
    }
    public override void DisplayFull()
    {
        Console.WriteLine($"{GetType()} Event");
        Display();
        Console.WriteLine($"Weather forecast: {_weather}");
    }
}