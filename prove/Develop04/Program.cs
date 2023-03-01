using System;

class Program
{
    static void Main(string[] args)
    
    {   
     
        int userChoice = 0;
         
        do{
        Console.Clear();
        Console.WriteLine("Main Menu");
        Console.WriteLine("1.Breathing Activity");
        Console.WriteLine("2.Reflection Activity");
        Console.WriteLine("3.Listing Activity");
        Console.WriteLine("4.Quit");
        Console.Write("What is your selction?");
        userChoice = Convert.ToInt32(Console.ReadLine());

        
    

        if (userChoice == 1){
            Console.Clear();
            Breathing breath = new Breathing("Breathing Activity","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
            Console.Clear(); 
            breath.Prepare();
            breath.DisplaySpinner();
            Console.Clear();
            breath.DisplayDuration();
            breath.StartBreathing();
            Console.Clear();
            breath.DisplayEndMessage();  
        }
        if (userChoice == 2){
            Console.Clear();
            Reflection reflect = new Reflection("Reflection Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
            reflect.DisplayStartMessage();
            Console.Clear();
            reflect.Prepare();
            reflect.DisplaySpinner();
            Console.Clear();
            reflect.DisplayDuration();
            reflect.StartReflection();
            Console.ReadLine();
            reflect.DisplaySpinner();
            Console.Clear();
            reflect.StartQuestions();
            Console.ReadLine();
            reflect.DisplaySpinner();
            Console.Clear();
            reflect.DisplayEndMessage(); 
        }
        if (userChoice == 3){
            Console.Clear();
            Listing list = new Listing("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
            list.DisplayStartMessage();
            list.Prepare();
            Console.Clear();
            list.ListingActivity();
            list.DisplayDuration();
            list.ListingCount();
            list.DisplaySpinner();
            Console.Clear();
            list.DisplayEndMessage();} 
    } while(userChoice !=4);
        }

    
    }
   