public class MathAssignment : Assignment //Inherits from Assignment giving it the methods and variables from the parent class
{
    //Declare the section and problems unique to Math Assignments
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string stuName, string topic, string tbSec, string prob)
    : base(stuName, topic) //Pass name and topic to base constructor.
    {
        _textbookSection = tbSec;
        _problems = prob;
    }

    public string GetHomeworkList()
    {
        return "Section "+ _textbookSection + " Problems " + _problems;
    }
}