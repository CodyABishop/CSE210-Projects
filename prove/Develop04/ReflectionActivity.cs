public class ReflectionActivity : Activity //Inherits from Activity Class
{
    //Declare the variables that describe this assignment. Set as constants to be used in constructor.
    private const string _activityType = "Reflection Activity";
    private const string _activityDescription = "This activity is designed to draw your focus to the times of your life you demonstrated strength, resilience, and will in a time of hardship. By recalling and focusing on this you can understand the power you demonstrate more fully so that you can apply it in other aspects of your life.";

    private const string _activitySignOff = "Great work on your reflections, hopefully you are feeling empowered and determined.";
    private string[] _reflectionPrompts = {
    "Think of a time when you stood up for someone you saw being mistrated.",
    "Think of a time when you perservered despite challenges before you.",
    "Think of a time when you helped a person who needed you.",
    "Think of a time when you acted selflessly even if it was to your own detriment."
    };    
    private string[] _reflectionQuestions = {
      "What did this experience mean to you?",
      "Is this the only time you've done this?",
      "What lead you to this course of action?",
      "How did its completion make you feel?",
      "Why is this specific experience the one that came to mind?",
      "What about your actions do you stand by?",
      "Did you learn anything from this experience which applies to other situations?",
      "What have you learned of yourself from this experience?",
      "Did you defy your own expectations with your actions in this experience?",
      "How can you remember the lessons you learned from this experience?",
      "If you could revisit the situation now, would you act the same way?"
    };
    public ReflectionActivity()
    : base(_activityType, _activityDescription, _activitySignOff) //Pass name and topic to base constructor.
    {
		
    }
	
	public void StartReflecting(){     
      DisplayStartMsg(); //Display a starting message defined by the parent class.
      Console.WriteLine("\nHow long would you like this Reflection Activity to take? Please enter the seconds in integer form.");
      SetActivityTime(Convert.ToInt32(Console.ReadLine()));
      DateTime startTime = DateTime.Now;
      DateTime futureTime = DateTime.Now.AddSeconds(GetActivityTime()); //Sets the activity cutoff time
      DateTime tempCounter; //Variable used for each of the subloops.
      Random randomGenerator = new Random();
      int promptSelected = randomGenerator.Next(0, (_reflectionPrompts.Length - 1));
      Console.WriteLine(_reflectionPrompts[promptSelected]);
      Console.WriteLine("Please reflect on the experience with the context of the questions as they appear. There is no wrong or right answer, your reflection is the goal.");
      
      List<int> displayedQuestions = new List<int>();   //Keeps track of what numbers 
      bool allShown = false;
      int questionSelected = 0;
      while (DateTime.Now < futureTime) //While loop handling the reflection activity
      {
        bool oldQuestion = true;
        while (oldQuestion){
          if(allShown){
            break;} //Exit early if all questions already shown.
          questionSelected = randomGenerator.Next(0, (_reflectionQuestions.Length));
          if(displayedQuestions.Contains(questionSelected)){
            //Repeats the while loop
          }
          else{
            displayedQuestions.Add(questionSelected); //Adds to the displayed questions list to avoid duplicates
            oldQuestion = false;
          }
          if(displayedQuestions.Count == _reflectionQuestions.Length){ //Failsafe for if all questions were displayed.
            Console.WriteLine("All questions have been displayed, please reflect on prior prompts.");
            allShown = true;
            oldQuestion = false;
            break;
          }
        }
        if(allShown == false){
          Console.WriteLine("\n"+_reflectionQuestions[questionSelected]);}
        tempCounter = DateTime.Now.AddSeconds(4); //4 seconds of thought for each prompt.
        while (DateTime.Now < tempCounter) //Simple spinner animation
        {
            Console.Write("+");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
        } 
      }
      SetDuration(DateTime.Now.Subtract(startTime)); //Create a timespan object and pass it over to the parent class for duration taken.
      DisplayEndMsg(); //Call the parent class's end mesage method.
	}
}