
using System;
public class Save{
public List<NewEntry> _entries = new List<NewEntry>();

public void DisplaySaveList(){
    foreach (NewEntry entry in _entries){
        entry.DisplayEntries();
    }
}
}