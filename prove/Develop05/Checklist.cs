public class Checklist:Goal{
    
    private int _num = 0;
    private int _goalCount{get; set;}
    private int _bonus {get; set;}
public Checklist(){
    
}
public Checklist(string name, string description, int goalCount, int points, int number, int bonus): base(name, description, points){
    _num = number;
    _goalCount = goalCount;
    _bonus = _bonus;
}
public override void RecordEvent(){
     _num++;
        Console.WriteLine($"Goal Progress: {Name} : {Points} ");
        if (_num == _goalCount){
            Points += 100;
            Console.WriteLine($"Goal Finished: {Name} (+100 bonus points) ");
        }
}
    public override string Status()
    {
        return $"Goal achieved: {_num} /{_goalCount} times:{Name} ";
    }
public override void GoalInfo(){
           Console.WriteLine("What is the name of your goal?");
             Name = Console.ReadLine();

            Console.WriteLine("What is a short description of it?");
             Description = Console.ReadLine();
      
           Console.WriteLine("Number of points for each time you accomplish this goal?");
            Points = Convert.ToInt32( Console.ReadLine());

           Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            _num = Convert.ToInt32( Console.ReadLine());

           Console.WriteLine($"How many bonus points for accomplishing your goal {_num}?");
           _bonus = Convert.ToInt32(Console.ReadLine());
    }
   // public string GoalCount(){
     //   foreach 
    //}
    public string  CurrentlyCompleted(){
        return $"{_goalCount}/{_num}";
    }
       public override string DisplayGoalInfo(){
        return$" Checklist, [ ] {Name},  ({Description}), {Points} -- Currently completed: {CurrentlyCompleted()} " ;    
   }
}

