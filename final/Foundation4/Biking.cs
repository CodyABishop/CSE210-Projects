public class Biking : Activity
{
    private double _speedKPH;

    public Biking(double speed, DateTime date, TimeSpan duration) : base ("Running", date, duration)
    {
        _speedKPH = speed;
    }
    public override double GetDistanceKM(){
        return Math.Round(_speedKPH*GetDuration()/60.0,2); //Speed * hours for distance
    }
    public override double GetSpeedKph(){
        return _speedKPH;
    }
    public override string GetSummary(){
        return $"Activity: {GetType()}\nDate: {GetDate().ToShortDateString()} at {GetDate().ToShortTimeString()}\nDistance: {Math.Round(GetDistanceKM(),2)}km\nAvg Speed: {GetSpeedKph()} kph\nPace: {GetPaceKph()} minutes per km\n";
    }
}