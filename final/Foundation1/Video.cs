public class Video //Class for the video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    List<Comment> _videoComments = new List<Comment>();
    public Video(string title, string author, int seconds) //Simple constructor to set the info
    {
        _title = title;
        _author = author;
        _lengthSeconds = seconds;
    }
    //Getters
    public string GetTitle() 
    {
        return _title;
    }
    public string GetAuthor() 
    {
        return _author;
    }
    public int GetLength() 
    {
        return _lengthSeconds;
    }
    public int GetNumComments() 
    {
        return _videoComments.Count;
    }
    
    //End Getters
    //Begin setters, included in the event a video's information needs updating
    public void SetTitle(string newTitle) 
    {
        _title = newTitle;
    }
    public void SetAuthor(string newAuthor) 
    {
        _author = newAuthor;
    }
    public void SetLength(int newLength) 
    {
        _lengthSeconds = newLength;
    }
    //End Setters
    //Other Methods
    public void AddComment(string comAuth, string comText) //Method to add a new comment
    {
        Comment newComment = new(comAuth,comText); //Instantiates a new comment
        _videoComments.Add(newComment); //Appends comment to the list
    }
    public void Display(){//Display video info
        Console.WriteLine("===========");
        Console.WriteLine("|         |");
        Console.WriteLine("|         |");
        Console.WriteLine("===========");
        Console.WriteLine(_title);
        Console.WriteLine($"Runtime: {_lengthSeconds} seconds");
        Console.WriteLine($"By {_author}");
        Console.WriteLine($"\n{GetNumComments()} Comments Posted");//Newline for spacing between video info and comment info
    }
    public void PrintAllComments() //Method to add a new comment
    {
        int commentNumber = 0;
        foreach (Comment c in _videoComments){            
            Console.WriteLine($"Comment #{++commentNumber}"); //Iterator increments before displaying for list to display from 1 rather than 0.
            c.Display();
        }
    }
}