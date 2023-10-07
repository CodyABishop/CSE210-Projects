using System;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> entryList = new List<Entry>();
    public void Display()
    {
        int dispIterator = 0;
        foreach (Entry i in entryList)
        {
            Console.WriteLine("Entry #{0}", dispIterator++);
            i.displayEntry();
        }
    }
}