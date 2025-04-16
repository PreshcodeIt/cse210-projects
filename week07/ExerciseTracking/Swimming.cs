public class Swimming : Activity
{
    // Private member variable for laps
    private int _laps; // in laps

    // Property to get/set the private laps variable
    public int Laps
    {
        get { return _laps; }
        set { _laps = value; }
    }

    public override double GetDistance() => Laps * 50 / 1000 * 0.62; // in miles

    public override double GetSpeed() => (GetDistance() / Duration) * 60;

    public override double GetPace() => Duration / GetDistance();
}
