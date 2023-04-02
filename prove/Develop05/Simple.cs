public class Simple: Goal{
    
   public Simple(){
    
   }

   public Simple(string name, string description, int points): base(name, description, points){
   
   }

    public override void RecordEvent()
    {
        Console.WriteLine($"Goal Completed:{Name} : {Points} ");
    }
        public override string Status(){
            return $"[] {Name}";
        }
        public override void GoalInfo(){
           Console.WriteLine("What is the name of your goal?");
             Name = Console.ReadLine();

            Console.WriteLine("What is a short description of it?");
             Description = Console.ReadLine();
      
           Console.WriteLine("What is the amount of points associated with this goal?");
            Points = Convert.ToInt32( Console.ReadLine());
    }
       public override string DisplayGoalInfo(){
        return$"Simple, [ ] {Name}, ({Description}), {Points}" ;    
   }
}