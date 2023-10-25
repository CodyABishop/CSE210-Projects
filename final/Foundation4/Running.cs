public class Running : Activity
{
    private double _distance;

    public Running(double distance, DateTime date, TimeSpan duration) : base ("Running", date, duration)
    {
        _distance = distance;
    }
    public override double GetDistanceKM(){
        return _distance;
    }
    public override double GetSpeedKph(){
        return Math.Round(_distance/GetDuration()*60.0,2);
    }
    public override string GetSummary(){
        return $"Activity: {GetType()}\nDate: {GetDate().ToShortDateString()} at {GetDate().ToShortTimeString()}\nDuration: {GetDuration()} Minutes\nDistance: {Math.Round(GetDistanceKM(),2)}km\nAvg Speed: {GetSpeedKph()} kph\nPace: {GetPaceKph()} minutes per km\n";
    }
}