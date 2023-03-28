public class Simple: Goal{
    
   

   public Simple(string name, string description, int points): base(name, description, points){
   
   }

    public override void RecordEvent()
    {
        Console.WriteLine($"Goal Completed:{Name} : {Points} ");
    }
        public override string Status(){
            return $"[] {Name}";
        }

}