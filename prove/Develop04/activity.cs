using System;
public class Activity{
    private string _name;
    private string _description;
    private int _duration;

    
    //method
    public void DisplayStartMessage(){
        Console.WriteLine($"You picked the {_name}");
        Console.WriteLine("");

        Console.WriteLine($"{_description}");
        Console.WriteLine("");

        Console.WriteLine($"How long would you like to do the {_name} in seconds?");
        int duration = Convert.ToInt32(Console.ReadLine());
        
        _duration = duration;
        }
public void Prepare(){
Console.WriteLine("Prepare to begin....");
}        
public void DisplaySpinner(){
     DateTime startTime = DateTime.Now;
DateTime futureTime = startTime.AddSeconds(3);

while (DateTime.Now < futureTime){
    Console.Write(".");
        Thread.Sleep(500);
}   
        
}

public void DisplayDuration(){
DateTime startTime = DateTime.Now;
DateTime futureTime = startTime.AddSeconds(_duration);

while (DateTime.Now < futureTime){
    
}
}   
    
    
    public void DisplayEndMessage(){
        Console.WriteLine("You did a great job!");
        Thread.Sleep(5000);
        Console.WriteLine("");

        Console.WriteLine($"You participated in the {_name}, for {_duration} seconds.");
        Thread.Sleep(5000);
        

    }
    public Activity(string name, string description, int duration){
        _name = name;
        _duration = duration;
        _description = description;
    }
    
    }

