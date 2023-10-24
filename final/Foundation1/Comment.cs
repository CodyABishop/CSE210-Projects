public class Comment //Class for the comment
{
    private string _author;
    private string _text;
    public Comment(string author, string text) //Simple constructor to set the info
    {
        _author = author;
        _text = text;
    }
    //Getters
    public string GetAuthor() 
    {
        return _author;
    }
    public string GetText() 
    {
        return _text;
    }
    //End Getters
    public void Display() 
    {
        Console.WriteLine($"User: {_author}");
        Console.WriteLine($"    {_text}");
    }
    //Setters omitted, comments can not be edited.
}