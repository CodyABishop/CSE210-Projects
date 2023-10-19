public class BreathingActivity : Activity //Inherits from Activity Class
{
    //Declare the variables that describe this assignment. Set as constants to be used in constructor.
    private const string _activityType = "Breathing Activity";
    private const string _activityDescription = "This activity will aid in relaxation via guided breathing. Please clear your mind and focus.";
    private const string _activitySignOff = "Great work on your guided breathing, hopefully you are feeling centered and stable.";
    public BreathingActivity()
    : base(_activityType, _activityDescription, _activitySignOff) //Pass name and topic to base constructor.
    {
      //Not much needed here.
    }
    public void StartBreathing(){       //Starts the activity.
      DisplayStartMsg(); //Display a starting message defined by the parent class.
      Console.WriteLine("\nHow long would you like this Breathing Exercise to take? Please enter the seconds in integer form.");
      SetActivityTime(Convert.ToInt32(Console.ReadLine()));
      DateTime startTime = DateTime.Now;
      DateTime tempCounter; //Variable used for each of the subloops, defined outside of them.
      DateTime futureTime = DateTime.Now.AddSeconds(GetActivityTime()); //Sets the activity cutoff tiem.
      while (DateTime.Now < futureTime) //While loop handling the activity as a whole.
      {
        if(DateTime.Now > futureTime){ //Extra break in case it's just gone over the edge
          break;
        }
        Console.Write("\nBreathe in");
        tempCounter = DateTime.Now.AddSeconds(4); //The breathe in and breathe out prompts are set to 4 seconds each. This enforced 8 second minimum is to ensure a proper breath in and out for the exercise.
        int i = 200;   // Used for the milisecond time
        while (DateTime.Now < tempCounter) //Loop for printing . where each one takes twice as long to appear as the last for a slow breath in.
        {
          Console.Write("."); //
          Thread.Sleep(i);
          i = i*2;
        }
        i = 1000;
        Console.Write("\nBreathe out");
        tempCounter = DateTime.Now.AddSeconds(4);
        while (DateTime.Now < tempCounter) //This loop is for the . after the "Breathe out", each one appears 100ms faster than the last.
        {
          Console.Write(".");
          Thread.Sleep(i);
          i = i - 100;
        }
      }
      SetDuration(DateTime.Now.Subtract(startTime)); //Create a timespan object and pass it over to the parent class for duration taken.
      DisplayEndMsg(); //Call the parent class's end mesage method.
	}

}