public class Listing : Activity{
    
    private List<string> _listPrompt = new List<string>(){
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"};
    private List<string> _listCount = new List<string>();
   

    public string ListingActivity(){
        Random rand = new Random();
        string _prompt = _listPrompt[rand.Next(0, _listPrompt.Count)];
        Console.WriteLine(_prompt);
        return _prompt;
    }
    

    
    public void ListingCount(){
        while (true) {
        Console.Write("Type Entry: ");
        String entry = Console.ReadLine();
        if (entry == ""){
            break;
        }_listCount.Add(new string(entry));

        }
        Console.WriteLine();
        Console.WriteLine("Entries in total: " + _listCount.Count);
    }
    public Listing(string name, string description, int duration) :base(name, description, duration){

    }
}