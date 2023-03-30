public class Eternal:Goal{
    
    private int _num = 0;

    public Eternal(){
        
    }
  public Eternal(string name, string description, int points, int number): base(name, description, points){
       _num = number; 
  }
    public override void RecordEvent()
    {
        _num++;
        Console.WriteLine($"Goal Progress: {Name} : {Points} ");
    }

    public override string Status()
    {
        return $"Number of times done goal: {_num} {Name}";
    }
}