public class Running : Activity
{
    // Private member variable for distance
    private double _distance; // in miles

    // Property to get/set the private distance variable
    public double Distance
    {
        get { return _distance; }
        set { _distance = value; }
    }

    public override double GetDistance() => Distance;

    public override double GetSpeed() => (Distance / Duration) * 60;

    public override double GetPace() => Duration / Distance;
}
