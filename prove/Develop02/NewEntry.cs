using System;
public class NewEntry{
    public string _date;
    public string _entry;
    public string _prompt;
   // public void DisplayRandom()
   // {
   //     Console.WriteLine($"{_prompt}");
    //}
    public void ShowDateAndEntry()
    {
        
        Console.WriteLine($"{_date} ({_entry}) ");
    }
}