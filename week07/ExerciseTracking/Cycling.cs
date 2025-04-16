public class Cycling : Activity
{
    // Private member variable for speed
    private double _speed; // in mph

    // Property to get/set the private speed variable
    public double Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    public override double GetDistance() => (Speed * Duration) / 60;

    public override double GetSpeed() => Speed;

    public override double GetPace() => 60 / Speed;
}
