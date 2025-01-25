using System;
using System.Collections.Generic;
using System.Linq;

// ScriptureReference Class
class ScriptureReference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;

    public ScriptureReference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
    }

    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Explicit Getter Methods
    public string GetBook() => _book;
    public int GetChapter() => _chapter;
    public int GetVerse() => _verse;
    public int? GetEndVerse() => _endVerse;

    public override string ToString()
    {
        return _endVerse.HasValue
            ? $"{_book} {_chapter}:{_verse}-{_endVerse}"
            : $"{_book} {_chapter}:{_verse}";
    }
}

// Word Class
class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Explicit Getter Methods
    public string GetText() => _text;
    public bool IsHidden() => _isHidden;

    // Methods to Modify State
    public void Hide() => _isHidden = true;

    public string Display() => _isHidden ? new string('_', _text.Length) : _text;
}

// Scripture Class
class Scripture
{
    private ScriptureReference _reference;
    private List<Word> _words;

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    // Explicit Getter Methods
    public ScriptureReference GetReference() => _reference;
    public List<Word> GetWords() => _words;

    public bool AllWordsHidden() => _words.All(w => w.IsHidden());

    public void HideRandomWords(int count = 3)
    {
        var unhidden = _words.Where(w => !w.IsHidden()).ToList();
        if (unhidden.Count == 0) return;

        var random = new Random();
        for (int i = 0; i < Math.Min(count, unhidden.Count); i++)
        {
            int index = random.Next(unhidden.Count);
            unhidden[index].Hide();
        }
    }

    public void Display()
    {
        Console.WriteLine(_reference);
        Console.WriteLine(string.Join(" ", _words.Select(w => w.Display())));
    }
}

// Program Class
class Program
{
    static void Main()
    {
        var reference = new ScriptureReference("Proverbs", 3, 5, 6);
        var scripture = new Scripture(reference,
            "Trust in the Lord with all your heart and lean not on your own understanding; " +
            "in all your ways submit to him, and he will make your paths straight.");

        var memorizer = new ScriptureMemorizer(scripture);
        memorizer.Start();
    }
}

// ScriptureMemorizer Class
class ScriptureMemorizer
{
    private readonly Scripture _scripture;

    public ScriptureMemorizer(Scripture scripture)
    {
        _scripture = scripture;
    }

    public void Start()
    {
        while (!_scripture.AllWordsHidden())
        {
            Console.Clear();
            _scripture.Display();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            _scripture.HideRandomWords();
        }

        Console.Clear();
        _scripture.Display();
        Console.WriteLine("\nMemorization complete!");
    }
}