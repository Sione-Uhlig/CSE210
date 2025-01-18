using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;

class Journal
{
     public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    
    public void DeleteEntry(string dateToDelete)
    {
        Entry entryToDelete = _entries.Find(entry => entry.Timestamp == dateToDelete);
          if (entryToDelete != null)
        {
            _entries.Remove(entryToDelete);
            Console.WriteLine("Entry deleted successfully.");
        }
        else
        {
            Console.WriteLine("Entry not found.");
        }

    }
    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry(parts[2], parts[1]);
            entry.Timestamp = parts[0];
            _entries.Add(entry);

        }
         Console.WriteLine($"Successfully loaded file: {filename}");
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry.Timestamp}|{entry.Prompt}|{entry.Text}");
            }
        }

        Console.WriteLine($"Successfully Saved to file: {filename}");
    }
   

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.GetFormattedEntry());
        }
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Delete entry\n6. Quit");
        Console.Write("What would you like to do? ");
    }
    
}