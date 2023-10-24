public class EternalGoal : Goal
{
    private int _stepAward; //Used for bonus in this context
    private const string _type = "Eternal"; //Type is a constant
    private int _currentSteps; 
    public EternalGoal(string name, string description, bool completion, int points) : base(_type, name, description, completion)
    {
        _stepAward = points; //Sets points to be awarded on completion of a given number of the task
        _currentSteps = 0; //Withthis constructor, current steps always 0
    }    
    public EternalGoal(string[] save) : base(save[0], save[1], save[2], save[4]=="True")
    {
       _stepAward = Convert.ToInt32(save[3]);
       _currentSteps = Convert.ToInt32(save[5]);
    }    
    public int GetStepValue() //Simple getter for per-step value
    {
        return _stepAward;
    }
    public int GetSteps() //Simple getter for current number of steps
    {
        return _currentSteps;
    }
    public override int AwardPoints() //Awards points each completion
    {
        return _stepAward;
    }
    public override int AwardInitialPoints() //Awards points missing on load
    {
        return _stepAward*_currentSteps;
    }
    public override int CompleteTask() //Marks the step as complete
    {
        _currentSteps++; //Increase the current steps
        return AwardPoints();
    }
    public override string[] GetSaveData()
    {
        string[] SaveData = {_type, GetName(), GetDescription(), _stepAward.ToString(), GetCompletion().ToString(), _currentSteps.ToString()};
        return SaveData;
    }
    public override void Display()
    {
        Console.WriteLine("Eternal Goal: " + GetName());
        Console.WriteLine("Steps Taken: " + _currentSteps.ToString());
        Console.WriteLine("Points per step: " + _stepAward);
        Console.WriteLine("Description of goal: " + GetDescription());
    }
        public override void DisplayShort()
    {
        Console.Write("[" + _currentSteps + "] : " + GetName() + " : " + _currentSteps + " Points per Step | "+ "\n");
    }
}
    