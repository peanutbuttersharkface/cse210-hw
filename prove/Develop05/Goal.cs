public abstract class Goal{
    private string _name;
    private string _description;

    private int _points;
    List<string> _totalPoints;

    

   // public Goal(string name, string description, int points, List<string> totalPoints){
    //    _name = name;
    //    _description = description;
    //    _points = points;
    //    _totalPoints = totalPoints;
    
   // }
    
    public void DisplayGoalInfo(){
        Console.WriteLine($"{_name}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"{_points}");
        Console.WriteLine($"{_totalPoints}");
    }

    public void RecordEvent(){

    }
    public void IsComplete(){

    }


    //public abstract int GetTime();
    //public abstract int GetPoints();
    public void GoalInfo(){
           Console.WriteLine("What is the name of your goal?");
            Console.Read();

            Console.WriteLine("What is a short description of it?");
            Console.Read();
      
           Console.WriteLine("What is the amount of points associated with this goal?");
           Console.Read();
    }

    //public void GoalBonusPoints(){
     //   Console.WriteLine("How many bonus points for completing the activity?");
    //    Console.Read();
    //}
    }