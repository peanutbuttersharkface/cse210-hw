using System;

class Program
{
    static void Main(string[] args)
    {
        
        int userChoice = 0;
         
        do{
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("You have 0 points.");
        Console.WriteLine("");
        Console.WriteLine("Welcome to your Eternal Quest!");
        Console.WriteLine("Main Menu");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.WriteLine("7. other");
        Console.Write("What is your selction?");
        userChoice = Convert.ToInt32(Console.ReadLine());

        if (userChoice == 1){
            Console.Clear();
            //make a list to put goals in
            //List<Goal> _current = new List<Goal>();
            int choice = 0;
            do{
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("4. Quit");
                Console.WriteLine("Which Goal would you like to make?");
                choice = Convert.ToInt32(Console.ReadLine());
               
            
            if (choice == 1){
            
                Simple goal1 = new Simple();
                goal1.GoalInfo();
                Console.Read();
               //_current.Add(goal1);
                return;
           

            // save to a list

             //info =(name, description, points);
            //Goal goal1 = new Goal($"{name}, {description}, {points}, {bonusPoints}")
           
            //goal._newGoal.Add($"{name}, {description}, {points}, {bonusPoints}");
           
            
            } 
            if (choice == 2){

            
                Eternal goal2 = new Eternal();
                goal2.GoalInfo();
                Console.Read();
                break;
            // save to the list
            }

            if (choice == 3){

            
                Checklist goal3 = new Checklist();
                goal3.GoalInfo();
                Console.Read();
                // how many times to complete
                Console.WriteLine("How many bonus points for completing goal?");
                Console.Read();
                break;
            
             }
            } while (choice <4); break;}

        if (userChoice == 2){
            Console.WriteLine("The goals are:");
            
            //Console.WriteLine(show the list);
           
        }
        if (userChoice == 3){
            //Save the goals
            } 
        if (userChoice == 4){
            //Load Goals
            }  
        if (userChoice == 5){

            //record event
            }       
        } while(userChoice <6);
        } 
}
