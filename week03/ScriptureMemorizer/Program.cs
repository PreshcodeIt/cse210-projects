using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Exceeding Requirements:
// - Loads multiple scriptures from a file
// - Randomly selects a scripture to memorize
// - Tracks memorization progress
// - Uses encapsulation with multiple classes

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = LoadScripturesFromFile("scriptures.txt");

        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found.");
            return;
        }

        Random random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

        while (!selectedScripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine($"\nProgress: {selectedScripture.GetHiddenWordCount()} / {selectedScripture.GetTotalWordCount()} words hidden");
            Console.Write("\nPress [Enter] to hide more words or type 'quit' to exit: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            selectedScripture.HideRandomWords(random, 3);
        }

        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText());
        Console.WriteLine("\nAll words hidden. Good job!");
    }

    static List<Scripture> LoadScripturesFromFile(string fileName)
    {
        List<Scripture> scriptures = new List<Scripture>();

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2)
                {
                    Reference reference = Reference.Parse(parts[0].Trim());
                    string text = parts[1].Trim();
                    scriptures.Add(new Scripture(reference, text));
                }
            }
        }

        return scriptures;
    }
}