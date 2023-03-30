public class Checklist:Goal{
    
    private int _num = 0;
    private int _goalCount;
public Checklist(){
    
}
public Checklist(string name, string description, int goalCount, int points, int number): base(name, description, points){
    _num = number;
    _goalCount = goalCount;
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
}

