using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();;
        job1.companyName = "Google";
        job1.jobTitle = "Morality Engineer";
        job1.startYear = 2002;
        job1.endYear = 2016;
        Job job2 = new Job();
        job2.companyName = "Jim's Mystical Bongo Plaza";
        job2.jobTitle = "Bongo Shaper";
        job2.startYear = 2021;
        job2.endYear = 2022;
        Resume myResume = new Resume();
        myResume.resumeOwnerName = "John Carmack";
        myResume.jobList .Add(job1);
        myResume.jobList .Add(job2);
        myResume.Display();
    }
}
