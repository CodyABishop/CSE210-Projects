public class CheckGoal : Goal
{
    private int _completionAward; 
    private const string _type = "Check"; //Type is a constant
    private int _stepAward; 
    private int _stepsToFinish; 
    private int _currentSteps; 
    public CheckGoal(string name, string description, bool completion, int points, int stepPoints, int steps) : base(_type, name, description, completion)
    {
        _completionAward = points; //Sets points to be awarded on completion of a given number of the task
        _stepAward = stepPoints; //Sets points to be awarded on completion of the step of the task
        _stepsToFinish = steps; //Sets how many times task must be completed
        _currentSteps = 0; //Withthis constructor, current steps always 0
    }    
    public CheckGoal(string[] save) : base(save[0], save[1], save[2], save[4]=="True")
    {
       _completionAward = Convert.ToInt32(save[3]);
       _stepAward = Convert.ToInt32(save[5]);
       _stepsToFinish = Convert.ToInt32(save[6]);
       _currentSteps = Convert.ToInt32(save[7]);
    }    
    public int GetPointValue() //Simple getter with no check for completion.
    {
        return _completionAward;
    }
    public int GetStepValue() //Simple getter for per-step value
    {
        return _stepAward;
    }
    public int GetSteps() //Simple getter for current number of steps
    {
        return _currentSteps;
    }
    public override int AwardInitialPoints() //Awards points missing on load
    {
        if(GetCompletion()){
            return (_currentSteps*_stepAward)+_completionAward;
        } else {
            return (_currentSteps*_stepAward);
        }
    }
    public override int AwardPoints() //Awards points if completed
    {
        if(GetCompletion())
        {
            return _completionAward;
        }
        else{
            return 0;
        }
    }
    public override int CompleteTask() //Marks the step as complete
    {
        if(++_currentSteps == _stepsToFinish)
        {
            SetComplete();
            return AwardPoints()+_stepAward;
        } else 
        {
            return _stepAward;
        }
    }
    public override string[] GetSaveData()
    {
        string[] SaveData = {_type, GetName(), GetDescription(), GetPointValue().ToString(), GetCompletion().ToString(), _stepAward.ToString(), _stepsToFinish.ToString(),_currentSteps.ToString()};
        return SaveData;
    }
    public override void Display()
    {
        Console.WriteLine("Checklist Goal: " + GetName());
        Console.WriteLine("Steps Taken: " + _currentSteps.ToString());
        Console.WriteLine("Steps to Complete: " + _stepsToFinish.ToString());
        Console.Write("Completed: ");
        if(GetCompletion()){
            Console.Write("[X]\n");
        }else{
            Console.Write("[ ]\n");
        }
        Console.WriteLine("Points per step: " + _stepAward);
        Console.WriteLine("Points upon Completion: " + _completionAward);
        Console.WriteLine("Description of goal: " + GetDescription());
    }
        public override void DisplayShort()
    {
        if(GetCompletion()){
            Console.Write("[x] : " + GetName() + " : " + _currentSteps + " out of "  + _stepsToFinish + " | " + _stepAward + " Points per Step with " + _completionAward + " bonus on completion | " + "\n");
        }else{
            Console.Write("[ ] : " + GetName() + " : " + _currentSteps + " out of "  + _stepsToFinish + " | " + _stepAward + " Points per Step with " + _completionAward + " bonus on completion | " + "\n");
        }
    }
}
    