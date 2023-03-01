
public class Breathing : Activity 
{
   
   
    public void StartBreathing()
    {
        Console.WriteLine("");
        Console.WriteLine("Breath in....");
        Thread.Sleep(5000);

        Console.WriteLine("");
        Console.WriteLine("Breathe out....");
        Thread.Sleep(5000);

    }
    public Breathing(string name, string description, int duration) : base(name, description, duration){
       
    }
}