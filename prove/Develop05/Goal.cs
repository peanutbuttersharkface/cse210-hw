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
    
    public virtual string DisplayGoalInfo(){
        return$"{_name} \n {_description} \n {_points}" ;    
   }

    public virtual void RecordEvent(){

    }
    public abstract string Status();
    
    public virtual void GoalInfo(){
           Console.WriteLine("What is the name of your goal?");
            string _name = Console.ReadLine();

            Console.WriteLine("What is a short description of it?");
            string _description = Console.ReadLine();
      
           Console.WriteLine("What is the amount of points associated with this goal?");
           int _points = Convert.ToInt32( Console.ReadLine());
    }

    
    }