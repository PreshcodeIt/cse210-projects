using System;

public abstract class Activity
{
    // Private member variables
    private DateTime _date;
    private int _duration; // in minutes

    // Properties to get/set private fields
    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

    // Abstract methods for calculating distance, speed, and pace
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Get the summary string
    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {this.GetType().Name} ({Duration} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
