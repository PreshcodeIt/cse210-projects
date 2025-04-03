// for the exceeding requirement i added a Saving and loading a log file. where the program display
// the logs of past activities


using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\nChoose an activity:");
            Console.WriteLine("1. Breathing\n2. Reflection\n3. Listing\n4. View Logs\n5. Exist");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            if (choice == "5") break;

            if (choice == "4")
            {
                LogManager.LoadLog(); // View logs
                continue;
            }

            MindfulnessActivity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => throw new Exception("Invalid choice")
            };

            if (activity == null)
                break;

            activity.Run();
        }
    }
}
