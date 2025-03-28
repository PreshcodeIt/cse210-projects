using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(Random rand, int count)
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        if (visibleWords.Count == 0) return;

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} - " + string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    public int GetHiddenWordCount()
    {
        return _words.Count(w => w.IsHidden());
    }

    public int GetTotalWordCount()
    {
        return _words.Count;
    }
}
