public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;

    public Reference(string book, int chapter, int verse, int? endVerse = null)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public static Reference Parse(string input)
    {
        // Example input: "2 Nephi 2:25" or "Proverbs 3:5-6"
        var parts = input.Split(' ');

        // Find the last element that contains a colon (the chapter and verse)
        int index = Array.FindIndex(parts, p => p.Contains(':'));
        if (index == -1 || index == 0)
            throw new FormatException("Invalid scripture reference format.");

        string book = string.Join(" ", parts.Take(index)); // Handles "2 Nephi"
        string chapterVerse = parts[index];

        string[] verseParts = chapterVerse.Split(':'); // "2:25" → ["2", "25"]
        int chapter = int.Parse(verseParts[0]);

        int verseStart;
        int verseEnd;
        if (verseParts[1].Contains("-"))
        {
            string[] range = verseParts[1].Split('-');
            verseStart = int.Parse(range[0]);
            verseEnd = int.Parse(range[1]);
        }
        else
        {
            verseStart = verseEnd = int.Parse(verseParts[1]);
        }

        return new Reference(book, chapter, verseStart, verseEnd);
    }

    public string GetDisplayText()
    {
        return _endVerse.HasValue
            ? $"{_book} {_chapter}:{_verse}-{_endVerse}"
            : $"{_book} {_chapter}:{_verse}";
    }
}
