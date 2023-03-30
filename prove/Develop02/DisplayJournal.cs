using System.IO;

public class DisplayJournal{

    public void Journal(){
     Console.WriteLine("What is the filename?");
         string filename = Console.ReadLine();
         string[] lines = System.IO.File.ReadAllLines(filename);

         foreach (string line in lines){
          string[] parts = line.Split(",");

          string _date = parts[0];
          string _prompt = parts[1];
          string _entry = parts[2];
       }}
}