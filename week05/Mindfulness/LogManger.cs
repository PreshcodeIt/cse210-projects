using System;
using System.IO;

public static class LogManager
{
    private static string logFilePath = "mindfulness_log.txt";

    // Method to save logs
    public static void SaveLog(string activityName, int duration)
    {
        string logEntry = $"{DateTime.Now}: {activityName} for {duration} seconds";
        File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
    }

    // Method to load and display logs
    public static void LoadLog()
    {
        Console.Clear();
        if (File.Exists(logFilePath))
        {
            Console.WriteLine("📜 Mindfulness Log History 📜");
            string[] logs = File.ReadAllLines(logFilePath);
            foreach (string log in logs)
            {
                Console.WriteLine(log);
            }
        }
        else
        {
            Console.WriteLine("No logs found.");
        }
        Console.WriteLine("\nPress Enter to return...");
        Console.ReadLine();
    }
}
