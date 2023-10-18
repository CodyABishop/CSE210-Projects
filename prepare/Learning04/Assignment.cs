public class Assignment
{
    //Declarations
    private string _studentName;
    private string _topic;

    public Assignment(string stuName, string topic) //Standard constructor to assign name and topic
    {
        _studentName = stuName;
        _topic = topic;
    }

    //Begin Getters. No setters for security, shouldn't need to be changed after initial construction
    public string GetStudentName() //Returns the name
    {
        return _studentName;
    }

    public string GetTopic() //Returns the topic
    {
        return _topic;
    }

    public string GetSummary() //Returns name and topic with slight formatting.
    {
        return _studentName + " - " + _topic;
    }
}