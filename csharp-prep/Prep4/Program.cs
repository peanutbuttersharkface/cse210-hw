using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>();
        int newNumbers = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        

        
        while (newNumbers != 0)
        {
            Console.Write("Enter a number:");

            string answer = Console.ReadLine();
            newNumbers = int.Parse(answer);

            if (newNumbers != 0)
            {
              number.Add(newNumbers);
            }
        }

        int sum = 0;
        foreach (int numbers in number)
        {
            sum += numbers;
        }
            
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / number.Count;
        Console.WriteLine($"The average is {average}");

        int max = number[0];

        foreach (int numbers in number)
        {
            if (numbers > max)
            {
                max = numbers;
            }
        }

        Console.WriteLine($"The max is:{max}");
    }
        
    
}