public abstract class Goal{
    private string _name;
    private string _description;

    private int _points;
    

    public string Name{
        get{
            return _name;
        }
        set{
            _name = value;
        }
    }

    public string Description{
        get{
            return _description;
        }
        set{
            _description = value;
        }
    }

    public int Points{
        get{
            return _points;
        }
        set{
            _points = value;
        }
    }
    public Goal(){

    }
    public Goal(string name, string description, int points){
        _name = name;
       _description = description;
       _points = points;
    
    
    }
    
    public void DisplayGoalInfo(){
        Console.WriteLine($"{_name}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"{_points}");
        
   }

    public virtual void RecordEvent(){

    }
    public abstract string Status();
    
    public void GoalInfo(){
           Console.WriteLine("What is the name of your goal?");
            Console.ReadLine();

            Console.WriteLine("What is a short description of it?");
            Console.ReadLine();
      
           Console.WriteLine("What is the amount of points associated with this goal?");
           Console.ReadLine();
    }

    
    }