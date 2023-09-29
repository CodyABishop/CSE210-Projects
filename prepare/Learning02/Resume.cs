using System;

public class Resume
{
    public string resumeOwnerName;
    public List<Job> jobList = new List<Job>();
    public void Display()
    {
        Console.WriteLine("Name: " + resumeOwnerName);
        Console.WriteLine("Jobs:");

        foreach (Job i in jobList)
        {
            i.DisplayJobInfo();
        }
    }
}