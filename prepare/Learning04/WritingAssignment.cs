public class WritingAssignment : Assignment //Inherits from Assignment giving it the methods and variables from the parent class
{
    //Declare the title, private for security
    private string _title;
    public WritingAssignment(string stuName, string topic, string title)
        : base(stuName, topic) //Pass the name and topic to the base constructor
    {
        _title = title; //Assigns title set in constructor
    }

    public string GetWritingInformation() //Returns the information without printing.
    {
        string studentName = GetStudentName();
        return _title + " by " + studentName;
    }
}