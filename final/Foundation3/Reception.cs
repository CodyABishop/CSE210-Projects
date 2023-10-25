public class Reception : Event
{
    private string _RSVPEmail;

    public Reception(string title, string description, DateTime date, Address addr, string email) : base ("Outdoor", title, description, date, addr)
    {
        _RSVPEmail = email;
    }
    public override void DisplayFull()
    {
        Console.WriteLine($"{GetType()} Event");
        Display();
        Console.WriteLine($"Email here for your RSVP: {_RSVPEmail}");
    }
}