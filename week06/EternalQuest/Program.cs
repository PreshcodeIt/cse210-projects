// --------------------------
// Eternal Quest Program
// Exceeding Requirements:
// - Implemented a Leveling system based on score milestones (Level = Score/500 + 1)
// - Bonus points added when completing Checklist Goals
// - Full save/load system that restores all goal types with progress
// - Clean and user-friendly prompts and menus
// --------------------------


class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.LoadGoals();

        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine($"Current Score: {goalManager.Score} | Level: {goalManager.Level}");
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.ListGoals();
                    break;
                case "3":
                    goalManager.RecordEvent();
                    break;
                case "4":
                    goalManager.SaveGoals();
                    break;
                case "5":
                    goalManager.LoadGoals();
                    break;
                case "6":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
