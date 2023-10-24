public abstract class Goal //Abstract due to abstract methods. Not intended to be created on its own.
{
    private string _type; //Stores what type of activity it is
    private string _name; //Stores a specific name of the activity
    private string _description; //Stores a description of the activity, should show point awards and requirements.
    private bool _complete; //Completion status
    public Goal(string type, string name, string description, bool complete) //Simple empty constructor to be used on activity creation initially.
    {
      _type = type;
      _name = name;
      _description = description;
      _complete = complete;
    }
    //Getters
    public bool GetCompletion() //Getter for completion status
    {
        return _complete;
    }
    public string GetName() //Getter for name
    {
        return _name;
    }
    public string GetDescription() //Getter for completion status
    {
        return _description;
    }
    //Setters
    public void SetComplete() //Setter for completeness
    {
        _complete = true;
    }
    //Abstract methods
    public abstract int AwardPoints(); //An abstract method to output the points.
    public abstract int AwardInitialPoints(); //An abstract method to output the points on load rather than during operation.
    public abstract string[] GetSaveData(); //Should return a string array for save purposes
    public abstract int CompleteTask(); //Should be used to indicate a task is completed.
    public abstract void Display(); //Should be used to print the goal in a pleasant format for the user.
    public abstract void DisplayShort(); //Should be used to print the Goal in a one-line format that's descriptive for a list.
}