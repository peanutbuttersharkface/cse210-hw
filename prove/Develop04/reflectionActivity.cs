using System;
public class Reflection: Activity
{
    private List<string>_prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string>_questions = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"};
    public string StartReflection(){
        Random rand = new Random();
        string _prompt = _prompts[rand.Next(0, _prompts.Count)];
        Console.WriteLine(_prompt);
        return _prompt;
    
}
    public string StartQuestions(){
        Random rand2 = new Random();
        string _question = _questions [rand2.Next(0, _questions.Count)];
        Console.WriteLine(_question);
        return _question;
    
} 
    public Reflection(string name, string description, int duration) :base(name, description, duration){

}

}