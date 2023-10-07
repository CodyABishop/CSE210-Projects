using System;

public class Entry
{
    public string journalTime;
    public string promptText;
    public string Response;

    public void displayEntry()
    {
        Console.WriteLine("Journal Entry of: " + journalTime);
        Console.WriteLine("Prompt: " + promptText);
        Console.WriteLine("Response: " + Response);
    }
}