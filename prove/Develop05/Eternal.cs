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
    public override void GoalInfo(){
           Console.WriteLine("What is the name of your goal?");
             Name = Console.ReadLine();

            Console.WriteLine("What is a short description of it?");
             Description = Console.ReadLine();
      
           Console.WriteLine("Number of points for each time you accomplish this goal?");
            Points = Convert.ToInt32( Console.ReadLine());
    }
       public override string DisplayGoalInfo(){
        return$"Eternal, [ ] {Name},  ({Description}), {Points} ";    
   }
}