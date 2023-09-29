using System;

public class Job
{
    public string companyName;
    public string jobTitle;
    public int startYear;
    public int endYear;

    public void DisplayJobInfo()
    {
        Console.WriteLine(jobTitle+" ("+companyName+") "+startYear+"-"+endYear);
    }
}