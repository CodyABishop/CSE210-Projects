public abstract class Activity
{
    private string _type; //Type of exercise.
    private DateTime _dateTime; //Date of the exercise
    private TimeSpan _duration; //Tracks how long user exercised for
    public Activity(string type, DateTime date, TimeSpan duration)
    {
        _type = type;
        _dateTime = date;
        _duration = duration;
    }
    public double GetDuration(){
        return _duration.TotalMinutes;
    }
    public DateTime GetDate(){
        return _dateTime;
    }
    public void SetDate(TimeSpan duration){
        _duration = duration;
    }
    public DateTime SetDuration(){
        return _dateTime;
    }
    public abstract double GetDistanceKM();
    public abstract double GetSpeedKph();
    public abstract string GetSummary();
    public double GetPaceKph(){ //Identical in all cases, so contained in Activity instead of overrides.
        return Math.Round(60.0/GetSpeedKph(),2);
    }
}