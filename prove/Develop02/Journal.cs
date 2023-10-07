using System;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entryList = new List<Entry>();
    public void Display()
    {
        int dispIterator = 0;
        foreach (Entry i in _entryList)
        {
            Console.WriteLine("Entry #{0}", dispIterator++);
            i.DisplayEntry();
        }
    }
}