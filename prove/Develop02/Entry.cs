using System;

public class Entry
{
    public string _journalTime;
    public string _promptText;
    public string _response;

    public void DisplayEntry()
    {
        Console.WriteLine("Journal Entry of: " + _journalTime);
        Console.WriteLine("Prompt: " + _promptText);
        Console.WriteLine("Response: " + _response);
    }
}