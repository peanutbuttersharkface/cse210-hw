public class Save{
    // move list to program class  if (#) == 1, 2, 3 than 
    public List<Goal> _newGoal = new List<Goal>();
    
   public void RecordEvent(string name){
    foreach (Goal goal in _newGoal){
        if (goal.Name == name){
            goal.RecordEvent();
            return;
        }
    }
   }
    public void Status(){
        int totalPoints = 0;
        Console.WriteLine("Goals Created:");
        foreach (Goal goal in _newGoal){
            Console.WriteLine(goal.Status());
            totalPoints += goal.Points;
        }
        Console.WriteLine($"Total Points: {totalPoints}");
    }
   
}   
    
