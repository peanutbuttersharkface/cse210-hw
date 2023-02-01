using System;  

public class PromptGenerator 
{  
public static void Main()  
{  
// A array of prompts  
string[] prompts = { 
"Who was the most interesting person I interacted with today?",
 "What was the best part of my day?", 
 "How did I see the hand of the Lord in my life today?", 
 "What was the strongest emotion I felt today?",  
"If I had one thing I could do over today, what would it be?" };  
  
// Create a Random object  
Random rand = new Random();  
// Generate a random index less than the size of the array.  
int index = rand.Next(prompts.Length);  
// Display the result.  
Console.WriteLine($"{prompts[index]}");  
  
Console.ReadKey();  
}  
} 