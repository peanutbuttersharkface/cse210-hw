using System;

class Program
{
    static void Main(string[] args)
    
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
    
        

        int yourGuess = -1;
        while (yourGuess != magicNumber)
        {
              Console.Write("What is your guess?");
              yourGuess = int.Parse(Console.ReadLine());
              
              if (magicNumber > yourGuess)
              {
                Console.WriteLine("Higher");
              }
              else if (magicNumber < yourGuess)
              {
                Console.WriteLine("Lower");
              }
              else
              {
                Console.WriteLine("You guessed it!");
              }
        } 
    }

   
}