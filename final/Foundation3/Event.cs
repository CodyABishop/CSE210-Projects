public abstract class Event
{
    private string _type;
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private Address _address;
     public Event(string type, string title, string desc, DateTime dateTime, Address addr) //Simple constructor to set color
    {
        _type = type;
        _title = title;
        _description = desc;
        _dateTime = dateTime;
        _address = addr;
    }
    //Getters
    public string GetTitle() 
    {
        return _type;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetEventType() 
    {
        return _type;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public DateTime GetDateTime() 
    {
        return _dateTime;
    }
   public void Display(){
    Console.WriteLine($"Title: {_title}");
    Console.WriteLine($"Description: {_description}");
    Console.WriteLine($"Date: {_dateTime.ToShortDateString()}");
    Console.WriteLine($"Time: {_dateTime.ToShortTimeString()}");
    Console.WriteLine($"Address: {_address.Display()}");
   }
   public void DisplayShort(){
    Console.WriteLine($"{_type} Event: {_title}");
    Console.WriteLine($"Date: {_dateTime.ToShortDateString()}");
   }
   public abstract void DisplayFull(); //Declared as abstract to be specified in derived classes
}