public class Save{
    // move list to program class  if (#) == 1, 2, 3 than 
    public List<Goal> _newGoal = new List<Goal>();
    
    public void DisplayGoal(){
        foreach(Goal goal in _newGoal){
            goal.DisplayGoalInfo();
        }
    }

   

    //public Save(string name, string description, int points, List<string> totalPoints, List<Goal> newGoal): base(name, description, points, totalPoints){
     //   _newGoal = newGoal;
        //string name, string description, int points, List<string> totalPoints): base(name, description, points, totalPoints){
    //}
}   
    
