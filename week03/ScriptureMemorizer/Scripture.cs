using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public bool IsCompletelyHidden() => _words.All(w => w.IsHidden());

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
        Console.WriteLine(_reference.GetDisplayText());
        Console.WriteLine(string.Join(" ",_words.Select(w => w.GetDisplayText())));
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}: {string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
    }

    public void StartMemorization()
    {
        while (!IsCompletelyHidden())
        {
            Console.Clear();
            Display();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            var input = Console.ReadLine();
            if (input.ToLower() == "quit" || input == "4" )
                break;

            HideRandomWords();
        }

        Console.Clear();
        Display();
        Console.WriteLine("\nMemorization complete!");
    }
}
