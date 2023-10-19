using System.Reflection.Metadata;

public class ListingActivity : Activity //Inherits from Activity Class
{
    //Declare the variables that describe this assignment. Set as constants to be used in constructor.
    private const string _activityType = "Listing Activity";
    private const string _activityDescription = "This activity is designed to aid in focus on the good things in your life by drawing your focus to a specific area and having you list as many things as you can.";

    private const string _activitySignOff = "Great work on your listing, hopefully you are feeling empowered and determined.";
    private string[] _listingPrompts = {
      "Who are the people you appreciate in your day to day life?",
      "What are your strengths?",
      "What are topics you excel at?",
      "Who are some individuals you have helped in the last week?",
      "When have you felt the Holy Ghost this month?",
      "Who are your role models?"
    };    
    private List<string> _listedItems = new List<string>();   //Keeps track of what the user entered 

    public ListingActivity()
    : base(_activityType, _activityDescription, _activitySignOff) //Pass name and topic to base constructor.
    {
		
    }
	
	public void StartListing(){     
      DisplayStartMsg(); //Display a starting message defined by the parent class.
      Console.WriteLine("\nHow long would you like this Listing Activity to take? Please enter the seconds in integer form.");
      SetActivityTime(Convert.ToInt32(Console.ReadLine()));
      DateTime startTime = DateTime.Now;
      DateTime futureTime = DateTime.Now.AddSeconds(GetActivityTime()); //Sets the activity cutoff time
      DateTime tempCounter; //Variable used for each of the subloops.
      Random randomGenerator = new Random();
      int promptSelected = randomGenerator.Next(0, (_listingPrompts.Length - 1));
      Console.WriteLine(_listingPrompts[promptSelected]);
      Console.WriteLine("When the spinner stops, list as many fitting entries as you can until the time is up.");
      tempCounter = DateTime.Now.AddSeconds(4); //4 seconds of thought given.
      while (DateTime.Now < tempCounter) //Simple spinner animation
      {
          Console.Write("+");
          Thread.Sleep(300);
          Console.Write("\b \b");
          Console.Write("-");
          Thread.Sleep(300);
          Console.Write("\b \b");
      } 
      while (DateTime.Now < futureTime) //While loop handling the listing activity
      {
        _listedItems.Add(Console.ReadLine());
      }
      Console.WriteLine("Time is up. \nYou listed a total of " + _listedItems.Count + " items.");
      SetDuration(DateTime.Now.Subtract(startTime)); //Create a timespan object and pass it over to the parent class for duration taken.
      DisplayEndMsg(); //Call the parent class's end mesage method.
	}
}