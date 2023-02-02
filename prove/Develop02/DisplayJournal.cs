using System;
using System.IO;
public class DisplayJournal
{
    public static void Main(){
        string path = @"Journal.txt";
        if (!File.Exists(path)){
            string[] createText = {"My Journal"};
            File.WriteAllLines(path, createText);
        }
        string appendText = "This is extra text" + Environment.NewLine;
        File.AppendAllText(path, appendText);

        string[] readText = File.ReadAllLines(path);
        foreach (string s in readText){
            Console.WriteLine(s);
        }
     /* public List<NewEntry> _entrys = new List<NewEntry>();

      public void DisplayEntries(){

        foreach (NewEntry entry in _entrys){
            entry.ShowDateAndEntry();
        }
    }*/
    
}
}