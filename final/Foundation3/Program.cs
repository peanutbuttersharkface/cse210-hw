using System;

class Program
{
    static void Main(string[] args)
    {
        //create reception event
        Address address1 = new Address("158 Sandstone Way", "Howdy", "Nevada", 78951, "USA");
        Receptions reception1 = new Receptions("Thompson Wedding", "Wedding reception for Derek and Alicia Thompson", "3/12/2024", "7-9pm", address1, "Reception","thompsonreception2024@gmail.com");
        
        //create outdoor event
        Address address2 = new Address("456 Sunny Court", "Wellington", "Ohio", 56425, "USA");
        Outdoor outdoor1 = new Outdoor("Bike Show","Come see the different mountain and road bikes that are available for the whole family.", "4/26/2023","9am-3pm", address2, "Outdoor", "Partly Cloudy");

        //create lecture event
        Address address3 = new Address("899 University Dr.", "Kanasa City", "Kansas", 67852, "USA");
        Lecture lecture1 = new Lecture("Making Money in Retirement", "Learn how to earn money from what you have saved with your retirement.  It doesn't matter how little or lot you have saved there are lots of ideas to help you survive your retirement years.", "05/15/2023", "9-11am", address3, "Lecture", "Rondald Spring", 85);
        
        // call reception event standard details
        Console.WriteLine(reception1.StandardDetails());
        Console.WriteLine();
        // call reception full details
        Console.WriteLine(reception1.FullDetails() + reception1.ReceptionFullDetails());
        Console.WriteLine();
        // call reception short details
        Console.WriteLine(reception1.ShortDetails());
        Console.WriteLine();
        // call outdoor event standard details
        Console.WriteLine(outdoor1.StandardDetails());
        Console.WriteLine();
        // call outdoor event full details
        Console.WriteLine(outdoor1.FullDetails() + outdoor1.OutdoorFullDetails());
        Console.WriteLine();
        // call outdoor event short details
        Console.WriteLine(outdoor1.ShortDetails());
        Console.WriteLine();
        // call lecture standard details
           Console.WriteLine(lecture1.StandardDetails());
            Console.WriteLine();
        // call lecture full details
        Console.WriteLine(lecture1.FullDetails() + lecture1.LectureFullDetails());
        Console.WriteLine();
        // call lecture short details
        Console.WriteLine(lecture1.ShortDetails());
    }
}