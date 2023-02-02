using System;

class Program
{
    static void Main(string[] args)
    {
        Prompt prompt1 = new Prompt();
        prompt1._prompt =  "Who was the most interesting person I interacted with today?";

        Prompt prompt2 = new Prompt();
        prompt2._prompt = "What was the best part of my day?";

        Prompt prompt3 = new Prompt();
        prompt3._prompt =  "How did I see the hand of the Lord in my life today?";

        Prompt prompt4 = new Prompt();
        prompt4._prompt = "What was the strongest emotion I felt today?";

        Prompt prompt5 = new Prompt();
        prompt5._prompt = "If I had one thing I could do over today, what would it be?";

        PromptGenerator myGenerator = new PromptGenerator();
        myGenerator._prompt.Add(prompt1);
        myGenerator._prompt.Add(prompt2);
        myGenerator._prompt.Add(prompt3);
        myGenerator._prompt.Add(prompt4);
        myGenerator._prompt.Add(prompt5);

        myGenerator.DisplayPromptGenerator();

        NewEntry newEntry1 = new NewEntry();
        Console.WriteLine("Enter Date:");
        string _date = Console.ReadLine();
        Console.WriteLine("Entry:");
        string _entry = Console.ReadLine();

        DisplayJournal myJournal = new DisplayJournal();
        
        myJournal._entry.Add(newEntry1);
        myJournal.Main();

       
    }
    
}