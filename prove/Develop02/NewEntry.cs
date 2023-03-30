using System;

public class NewEntry {

    public string _date;
    public string _entry;
   
    public List<string> _prompts = new List<string>()
     {"Who was the most interesting person I interacted with today?", 
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?", 
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"};
    
    public string DisplayPrompt(){
        Random rand = new Random();
        string _prompt = _prompts[rand.Next(0, _prompts.Count)];
        Console.WriteLine(_prompt);
        return _prompt;
       
    }
   
    public void DisplayEntry(){
        Console.WriteLine($"{_date}, {DisplayPrompt()} {_entry}");
    }
    public string GetDate(){
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }

   
}