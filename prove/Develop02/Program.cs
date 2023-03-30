using System.IO;

class Program
{
    static void Main(string[] args)
    {//menu
        Console.WriteLine("Welcome to the Journal Program.");
        int pick = 0;
      do{
      
      Console.WriteLine("Please select one of the following options:");
      Console.WriteLine("1. Write");
      Console.WriteLine("2. Display");
      Console.WriteLine("3. Load");
      Console.WriteLine("4.Save");
      Console.WriteLine("5.Quit");
      Console.Write("What would you like to do?");
      pick = Convert.ToInt32(Console.ReadLine());

      NewEntry entry1 = new NewEntry();
      DisplayJournal disJournal = new DisplayJournal();
      //NewEntry entry2 = new NewEntry();
      Journal journal1 = new Journal();
      List<Journal> _journal = new List<Journal>();
      // if statement

      if(pick == 1)
      { journal1.ListEntries();
        entry1._date = "4/14/2023";
        entry1.DisplayPrompt();
        entry1._entry = "I got my homework done!";
        _journal.Add(journal1);
        //entry1._date = entry1.GetDate();
        //entry1.DisplayPrompt();
        //string _entry = Console.ReadLine();
        
        //journal1._entries.Add(entry1);
        }
      else if (pick == 2)
        { 
          journal1.ListEntries();
      }
      
      else if (pick == 3)
       {
        disJournal.Journal();
       }
      else if (pick == 4)
      {
          Console.WriteLine("What is the filename?");
          string filename = Console.ReadLine();
          using(StreamWriter outputFile = new StreamWriter(filename)){
          outputFile.WriteLine(entry1.GetDate());
          outputFile.WriteLine(entry1.DisplayPrompt());
          //outputFile.WriteLine(entry1.DisplayEntry());
      }
      }
      else if (pick == 5)
      {
         Console.WriteLine("Good Bye!");
      }
      } while(pick !=5);     
}
}