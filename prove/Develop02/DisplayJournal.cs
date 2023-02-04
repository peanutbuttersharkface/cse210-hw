using System;
using System.IO;

public class DisplayJournal{
    public List<NewEntry> _entries = new List<NewEntry>();

    public void Display()
    {
        foreach (NewEntry entry in _entries)
        {
            entry.Display();
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