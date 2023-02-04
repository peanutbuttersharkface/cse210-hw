using System;

public class NewEntry{
    public string _entry;
    public string _date;

    public string _prompt;
    
    public void Display(){
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_entry}");
    }
}