public class SimpleGoal : Goal
{
    private int _CompletionAward; 
    private const string _type = "Simple"; //Type is a constant
    public SimpleGoal(string name, string description, bool completion, int points) : base(_type, name, description, completion)
    {
        _CompletionAward = points; //Sets points to be awarded on completion of simple task.
    }    
    public SimpleGoal(string[] save) : base(save[0], save[1], save[2], save[4]=="True")
    {
       _CompletionAward = Convert.ToInt32(save[3]);
    }    
    public int GetPointValue() //Simple getter with no check for completion.
    {
        return _CompletionAward;
    }
    public override int AwardPoints() //Awards points if completed
    {
        if(GetCompletion())
        {
            return _CompletionAward;
        }
        else{
            return 0;
        }
    }
    public override int AwardInitialPoints() //Awards points missing on load
    {
        if(GetCompletion())
        {
            return _CompletionAward;
        }
        else{
            return 0;
        }
    }
    public override int CompleteTask() //Marks the task as complete and returns the amount of points given.
    {
        SetComplete();
        return _CompletionAward;
    }
    public override string[] GetSaveData()
    {
        string[] SaveData = {_type, GetName(), GetDescription(), GetPointValue().ToString(), GetCompletion().ToString()};
        return SaveData;
    }
    public override void Display()
    {
        Console.WriteLine("Simple Goal: " + GetName());
        Console.Write("Completed: ");
        if(GetCompletion()){
            Console.Write("[X]\n");
        }else{
            Console.Write("[ ]\n");
        }
        Console.WriteLine("Completion Points: " + GetPointValue().ToString());
        Console.WriteLine("Description of goal: " + GetDescription());
    }
    public override void DisplayShort()
    {
        if(GetCompletion()){
            Console.Write("[X] : "+ GetName()  + " : " + _CompletionAward + " Points" + "\n");
        }else{
            Console.Write("[ ] : "+ GetName()  + " : " + _CompletionAward + " Points" + "\n");
        }
    }
}