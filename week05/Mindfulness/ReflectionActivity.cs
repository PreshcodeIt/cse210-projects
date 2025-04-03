using System;
using System.Threading;

public class ReflectionActivity : MindfulnessActivity
{
    private List<string> Prompts = new List<string>
    {
        "Think of a time you helped someone.",
        "Think of a time you achieved something difficult.",
        "Think of a time you showed resilience."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?"
    };


    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times of strength and resilience.") { }

    public override void Run()
    {
        Start();
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
        Thread.Sleep(5000);

        for (int i = 0; i < _duration / 5; i++)
        {
            Console.WriteLine(questions[random.Next(questions.Count)]);
            Thread.Sleep(5000);
        }
        End();
    }
}


