using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> _newGoal = new List<Goal>();
        int userChoice = 0;
        Console.Clear();
        Console.WriteLine("Welcome to your Eternal Quest!");
        do{
        Console.WriteLine();
        Console.WriteLine("You have 0 points.");
        Console.WriteLine();
        Console.WriteLine("Main Menu");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("What is your selection?");
        userChoice = Convert.ToInt32(Console.ReadLine());

        if (userChoice == 1){
            Console.Clear();
           
            int choice = 0;
            
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("4. Quit");
                Console.WriteLine("Which Goal would you like to make?");
                choice = Convert.ToInt32(Console.ReadLine());
               
            if (choice == 1){
                Simple simple1 = new Simple();
                simple1.GoalInfo();
                _newGoal.Add(simple1); 
            } 
            else if (choice == 2){
                Eternal eternal1 = new Eternal();
                eternal1.GoalInfo();
                _newGoal.Add(eternal1);
            }
            else if (choice == 3){
                Checklist checklist1 = new Checklist();
                checklist1.GoalInfo();
                _newGoal.Add(checklist1); 
             }
            } 
        if (userChoice == 2){
            Console.WriteLine();
            Console.WriteLine("Your goals are:");
            Console.WriteLine();
            foreach (var goal in _newGoal){
                Console.WriteLine(goal.DisplayGoalInfo());
            } 
        }
        if (userChoice == 3){
            
            Console.WriteLine();
            Console.WriteLine("What is the filename you want to save your goals to?");
            string filename = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(filename)){
              foreach (var goal in _newGoal){
                 //outputFile.WriteLine(goal);
                 outputFile.WriteLine(goal.DisplayGoalInfo());
                 outputFile.WriteLine();
            }
            } }
        if (userChoice == 4){
           string filename = "goals.txt";
           string[] lines = System.IO.File.ReadAllLines(filename);
            foreach(var line in lines){
                Console.WriteLine(line);
            }
            }  
        if (userChoice == 5){
            Console.WriteLine("The goals are:");
           string filename = "goals.txt";
           string[] lines = System.IO.File.ReadAllLines(filename);
            foreach(var line in lines){
            Console.WriteLine(line);
            }
            Console.WriteLine("Which goal did you accomplish?");
            string answer = Console.ReadLine();
            if(answer == "simple"){
                Console.WriteLine("Congratulations! You have earned 100 points");
            } 
            else if (answer == "eternal"){
                Console.WriteLine("Congradulations! you earned 50 points");
            }     
            else if (answer =="checklist"){
                Console.WriteLine("Congradulations! You earned 50 points");
            }
        }
        } while(userChoice <6);     
    }
}

