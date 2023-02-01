using System; 

public class Save{


    public List<NewEntry> _NewEntry = new List<NewEntry>();

    public void ShowDateAndEntry()
    {
        Console.WriteLine($"NewEntry");
        foreach( NewEntry newEntry in _NewEntry)
        {
            newEntry.ShowDateAndEntry();
        }

    }

}