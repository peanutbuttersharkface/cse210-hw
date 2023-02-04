using System;

class Program
{
    static void Main(string[] args)
    {//menu
      Console.WriteLine("Welcome to the Journal Program.");
      Console.WriteLine("Please select one of the following options:");
      Console.WriteLine("1. Write");
      Console.WriteLine("2. Display");
      Console.WriteLine("3. Load");
      Console.WriteLine("4.Save");
      Console.WriteLine("5.Quit");
      Console.Write("What would you like to do?");
      string pick = Console.ReadLine();

      // if statement

      if(pick == "1")
      {
      NewEntry entry1 = new NewEntry();
      PromptGenerator prompt = new PromptGenerator();

      // gives the prompt
      entry1._prompt = prompt.Display();

      string response = Console.ReadLine();
      entry1._entry = response;

      entry1._date = "Jan 2023";

      journal._journal.Add(entry1);

      }
      
      else if (pick =="2")
      {
        journal.Display();
      }

      else if (pick =="3")
      {
        Console.WriteLine("What is the filename you would like to store your entries in?");
        string filename = Console.ReadLine();
        journal.Load(filename);
    }
      else if (pick =="4")
      {
        Console.WriteLine = ("What file would you like to save to?");
        string filename = Console.ReadLine();
        journal.Save(filename);
      }

      else if (pick =="5")
      {
        Console.WriteLine("Good Bye!");
      }
}
}