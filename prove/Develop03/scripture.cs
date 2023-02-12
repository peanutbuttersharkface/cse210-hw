
using System;


public class Scripture{
    private List<string>_text = new List<string>();

    public Scripture(string section)
    {
       string[] text = section.Split(" ");
       foreach(string word in text){
        _text.Add(word);
       }
    }
    public List<string>GetText(){
        return _text;
    }
    public void Display()
    {
        
       
        foreach (string word in _text){
            Console.Write($"{word} ");
        }
    }
    public void HiddenWords(){
        Random dash = new Random();
        _text[dash.Next(0, _text.Count)] ="__";
        _text[dash.Next(0, _text.Count)] ="__";
        _text[dash.Next(0, _text.Count)] ="__";
    }
   
}
