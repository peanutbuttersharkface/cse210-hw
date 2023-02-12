
using System;


class Program
{
     public static void Main(String[] args)
    {
       Reference refernce1 = new Reference("Moses", "1", "39", "For behold, this is my work and my glory - to bring to pass the immportality and eternal life of man.");
       refernce1.Display();

       string text = refernce1.GetText();
       Scripture section = new Scripture(text);

       section.Display();
       Console.WriteLine("Tap enter to continue, or type 'quit' to quit");

       string choice = Console.ReadLine();

       while(choice == ""){
         section.HiddenWords();
         Console.Clear();
         refernce1.Display();
         section.Display();
         choice = Console.ReadLine();

       }

        
    }

}