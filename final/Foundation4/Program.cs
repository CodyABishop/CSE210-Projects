using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> allActivities = new List<Activity>(); //By polymorphism, the running, biking, and swimming events can be added to this.
        DateTime runDate = DateTime.Parse("10/4/2023 12:15:12 PM"); //Datetime created via string parse
        TimeSpan runDuration = TimeSpan.FromMinutes(68.0); //Timespan created from minutes
        Running runAct = new(8.4,runDate,runDuration); //Create the running activity
        allActivities.Add(runAct); //Add to list
        DateTime bikDate = DateTime.Parse("11/4/2023 3:1:17 PM");
        TimeSpan bikDuration = TimeSpan.FromMinutes(121.0);
        Biking bikAct = new(11.7,bikDate,bikDuration);
        allActivities.Add(bikAct); //Add to list
        DateTime swimDate = DateTime.Parse("10/4/2023 12:15:12 PM");
        TimeSpan swimDuration = TimeSpan.FromMinutes(30);
        Swimming swimAct = new(30,swimDate,swimDuration);
        allActivities.Add(swimAct); //Add to list
        //Iterate through the list
        int i = 0;
        foreach (Activity act in allActivities){
            Console.WriteLine($"Activity #{++i}");
            Console.WriteLine(act.GetSummary());
        }

    }
}