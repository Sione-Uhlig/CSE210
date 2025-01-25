class ScriptureReference
{
    public string Book { get; }
    public int Chapter { get; }
    public int Verse { get; }
    public int? EndVerse { get; }

    public ScriptureReference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
    }

    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        Verse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        return EndVerse.HasValue
            ? $"{Book} {Chapter}:{Verse}-{EndVerse}"
            : $"{Book} {Chapter}:{Verse}";
    }
}

class Word
{
    public string Text { get; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide() => IsHidden = true;

    public string Display() => IsHidden ? new string('_', Text.Length) : Text;
}

class Scripture
{
    public ScriptureReference Reference { get; }
    public List<Word> Words { get; }
    public bool AllWordsHidden => Words.All(w => w.IsHidden);

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords(int count = 3)
    {
        var unhidden = Words.Where(w => !w.IsHidden).ToList();
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
        Console.WriteLine(Reference);
        Console.WriteLine(string.Join(" ", Words.Select(w => w.Display())));
    }
}

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

class ScriptureMemorizer
{
    private readonly Scripture _scripture;

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