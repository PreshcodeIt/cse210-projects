using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create instances of each activity type
        var activities = new List<Activity>
        {
            new Running { Date = DateTime.Parse("03 Nov 2022"), Duration = 30, Distance = 3.0 },
            new Cycling { Date = DateTime.Parse("03 Nov 2022"), Duration = 45, Speed = 15.0 },
            new Swimming { Date = DateTime.Parse("03 Nov 2022"), Duration = 30, Laps = 20 }
        };

        // Iterate over the list and display the summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
