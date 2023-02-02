using System;  

public class PromptGenerator 
{  
    
   public List<Prompt> _prompt = new List<Prompt>();

   public void DisplayPromptGenerator(){
    Console.WriteLine($"Random Prompt:{_prompt}");
    foreach (Prompt prompt in _prompt){
        prompt.DisplayPrompt();
    }
   }
 



 
 
} 