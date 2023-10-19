public class Activity
{
    //Declarations
    private string _activityType; //What type of activity
    private string _activityDescript; //Description of the activity
    private string _activitySignOff; //Ending Message of the activity
    private int _activityTime; //Time in seconds of the activity.
    private TimeSpan _elapsedDuration; //Time in seconds of the activity.

    public Activity(string type, string desc, string signOff) //Standard constructor to assign type and description of activity
    {
        _activityType = type;
		_activityDescript = desc;
        _activitySignOff = signOff;
    }
	
	public int GetActivityTime() //Getter for Activity Time.
	{
		return _activityTime;
	}	
	public void SetActivityTime(int actTime) //Setter for Activity Time.
	{
		_activityTime = actTime;
	}	
	public void SetDuration(TimeSpan dur) //Setter for Duration
	{
		_elapsedDuration = dur;
	}	

    //Start message common to all activities with specifics provided by constructor and setter.
    public void DisplayStartMsg() 
    {
        Console.WriteLine("Welcome to the " + _activityType);
        Console.WriteLine(_activityDescript);
    }
    public void DisplayEndMsg() //End message common to all activities with specifics provided by constructor and setter.
    {
        Console.WriteLine("\n" +_activitySignOff);      
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(2);
        currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("+");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
            currentTime = DateTime.Now;
        }
        Console.WriteLine("\nYou have completed a " + _activityType + " which took " + _elapsedDuration.TotalSeconds + " Seconds.");  
        futureTime = currentTime.AddSeconds(2);
        currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("+");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
            currentTime = DateTime.Now;
        } 
        }
        
}