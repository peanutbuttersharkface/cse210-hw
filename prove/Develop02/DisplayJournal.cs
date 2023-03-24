using System;
using System.IO;

public class DisplayJournal{
    public string _date;

    public string _prompt;
    public List<NewEntry> _entries = new List<NewEntry>();

    public void listEntries()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine("Entry:");
            foreach (NewEntry entry in _entries)
            {
                entry.DisplayEntry();
            }
    }

    public void Save(string filename)  
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_entries);
        }
    }

    public void Load(string filename)
    {
        
        string[] journal = System.IO.File.ReadAllLines(filename);
    }
}