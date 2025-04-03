using System;
using System.Threading;

public class ListingActivity : MindfulnessActivity
{
    private List<string> Prompts = new List<string>
    {
        "List people you appreciate.",
        "List your personal strengths.",
        "List things that make you happy."
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life.") { }

    public override void Run()
    {
        Start();
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
        Thread.Sleep(1000);

        Console.WriteLine("Start listing:");
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"{count + 1}. ");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items!");
        End();
    }
}
    
