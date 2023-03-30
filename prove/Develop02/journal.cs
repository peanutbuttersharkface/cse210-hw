using System;

public class Journal{
     

    public List<NewEntry> _entries = new List<NewEntry>();

   
    public void ListEntries(){
            Console.WriteLine($"Entries:");
                foreach(NewEntry entry in _entries){
                    entry.DisplayEntry();
                }
    }
}