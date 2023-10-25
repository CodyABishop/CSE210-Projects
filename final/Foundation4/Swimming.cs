public class Swimming : Activity
{
    private double _numLaps; //Double to allow partial laps

    public Swimming(double laps, DateTime date, TimeSpan duration) : base ("Running", date, duration)
    {
        _numLaps = laps;
    }
    public override double GetDistanceKM(){
        return Math.Round(_numLaps*50.0/1000.0,2);
    }
    public override double GetSpeedKph(){
        return Math.Round(GetDistanceKM()/GetDuration()*60,2);
    }
    public override string GetSummary(){
        return $"Activity: {GetType()}\nDate: {GetDate().ToShortDateString()} at {GetDate().ToShortTimeString()}\nLaps: {_numLaps}\nDistance: {GetDistanceKM()}km\nAvg Speed: {GetSpeedKph()} kph\nPace: {GetPaceKph()} minutes per km\n";
    }
}