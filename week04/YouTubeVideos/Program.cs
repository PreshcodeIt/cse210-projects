using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating videos
        Video video1 = new Video("C# Tutorial", "John Doe", 600);
        Video video2 = new Video("OOP in C#", "Jane Smith", 750);
        Video video3 = new Video("Design Patterns", "Bob Johnson", 900);

        // Adding comments to video1
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Awesome explanation."));

        // Adding comments to video2
        video2.AddComment(new Comment("David", "This really helped me."));
        video2.AddComment(new Comment("Eve", "Best video on OOP!"));
        video2.AddComment(new Comment("Frank", "Clear and concise."));

        // Adding comments to video3
        video3.AddComment(new Comment("Grace", "Love the examples!"));
        video3.AddComment(new Comment("Hank", "Well explained."));
        video3.AddComment(new Comment("Ivy", "Good job, keep it up!"));

        // Storing videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Displaying video information
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
