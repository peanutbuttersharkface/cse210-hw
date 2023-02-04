using System;
using System.IO;

public class DisplayJournal{
    public List<NewEntry> _journal = new List<NewEntry>();

    public void Display()
    {
        foreach (NewEntry entry in _journal)
        {
            entry.Display();
        }
    }

    public void Save(string filename)  
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_journal);
        }
    }

    public void Load(string filename)
    {
        
        string[] journal = System.IO.File.ReadAllLines(filename);
    }
}