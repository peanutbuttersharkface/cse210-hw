using System;


public class Scripture{
    private List<string>_text = new List<string>();

    public Scripture(string text)
    {
       string[] words = text.Split(" ");
       foreach(string word in words){
        _text.Add(word);
       }
    }

    public void Display()
    {
        
       
        foreach (string text in _text){
            Console.Write($"{text}");
        }
    }

   
}
