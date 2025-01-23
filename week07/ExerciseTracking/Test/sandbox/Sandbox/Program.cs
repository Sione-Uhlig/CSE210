// Scripture Memorizer Program
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture with multiple verses to demonstrate flexibility
        ScriptureReference reference = new ScriptureReference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, 
            "Trust in the Lord with all your heart and lean not on your own understanding; " +
            "in all your ways submit to him, and he will make your paths straight.");

        ScriptureMemorizer memorizer = new ScriptureMemorizer(scripture);
        memorizer.Start();
    }
}

class ScriptureReference
{
    public string Book { get; private set; }
    public int StartChapter { get; private set; }
    public int StartVerse { get; private set; }
    public int? EndVerse { get; private set; }

    // Constructor for single verse
    public ScriptureReference(string book, int chapter, int verse)
    {
        Book = book;
        StartChapter = chapter;
        StartVerse = verse;
    }

    // Constructor for verse range
    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        StartChapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        return EndVerse.HasValue 
            ? $"{Book} {StartChapter}:{StartVerse}-{EndVerse}" 
            : $"{Book} {StartChapter}:{StartVerse}";
    }
}

class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public string Display()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }
}

class Scripture
{
    private ScriptureReference _reference;
    private List<Word> _words;

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public ScriptureReference Reference => _reference;

    public bool AllWordsHidden => _words.All(word => word.IsHidden);

    public void HideRandomWords(int count = 3)
    {
        var unhiddenWords = _words.Where(w => !w.IsHidden).ToList();
        
        if (unhiddenWords.Count == 0) return;

        Random random = new Random();
        for (int i = 0; i < Math.Min(count, unhiddenWords.Count); i++)
        {
            int index = random.Next(unhiddenWords.Count);
            unhiddenWords[index].Hide();
        }
    }

    public void Display()
    {
        Console.WriteLine(_reference);
        Console.WriteLine(string.Join(" ", _words.Select(w => w.Display())));
    }
}

class ScriptureMemorizer
{
    private Scripture _scripture;

    public ScriptureMemorizer(Scripture scripture)
    {
        _scripture = scripture;
    }

    public void Start()
    {
        while (!_scripture.AllWordsHidden)
        {
            Console.Clear();
            _scripture.Display();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
                break;

            _scripture.HideRandomWords();
        }

        Console.Clear();
        _scripture.Display();
        Console.WriteLine("\nMemorization complete!");
    }
}