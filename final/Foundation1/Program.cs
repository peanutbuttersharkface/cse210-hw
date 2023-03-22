using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to put videos in
        List<Video> _videos = new List<Video>();

        // Video 1 
        Video video1 = new Video();
        video1._title = "Magnet Fishing at Bass Lake";
        video1._author = "Sam Thomas";
        video1._length = 300;
        _videos.Add(video1);
        
       
        
        // Video 1 comments
        Comment vid1com1 = new Comment();
        vid1com1._commenter = "Sally Fry";
        vid1com1._comment = "Where did you buy such a large maganet?";
        

        Comment vid1com2 = new Comment();
        vid1com2._commenter = "Micheal Ford";
        vid1com2._comment = "I only ever get fishing hooks when I magnet fish.";

        Comment vid1com3 = new Comment();
        vid1com3._commenter = "Bill Worth";
        vid1com3._comment = "Excited to see the next place you go.";

        video1._comments.Add(vid1com1);
        video1._comments.Add(vid1com2);
        video1._comments.Add(vid1com3);

        
        video1.listComments();
        Console.WriteLine();

        // Video 2
        Video video2 = new Video();
        video2._title = "Touching my Toes";
        video2._author = "Ronald Breeks";
        video2._length = 252;
        _videos.Add(video2);

        // Comments for Video 2
        Comment vid2com1 = new Comment();
        vid2com1._commenter = "Jack Mann";
        vid2com1._comment = "Way to be, I have never been able to touch my toes.";

        Comment vid2com2 = new Comment();
        vid2com2._commenter = "Sarah Straight";
        vid2com2._comment = "I love how you showed the whole process in one video.";

        Comment vid2com3 = new Comment();
        vid2com3._commenter = "Kate Mobile";
        vid2com3._comment = "Now you should try learning to do the splits.";

        video2._comments.Add(vid2com1);
        video2._comments.Add(vid2com2);
        video2._comments.Add(vid2com3);

        
        video2.listComments();
        Console.WriteLine();

        // Video 3
        Video video3 = new Video();
        video3._title = "Fixing my Kitchen Sink";
        video3._author = "Tom Rush";
        video3._length = 420;
        _videos.Add(video3);

        //Comments for Video 3
        Comment vid3com1 = new Comment();
        vid3com1._commenter = "Terry Pickler";
        vid3com1._comment = "Man this video helped me a lot, my faucet just bit the dust.";

        Comment vid3com2 = new Comment();
        vid3com2._commenter = "Perry Woods";
        vid3com2._comment = "There is plumbers putty that can help with your problem.";

        Comment vid3com3 = new Comment();
        vid3com3._commenter = "Jenny Lance";
        vid3com3._comment = "What a good husband!";

        video3._comments.Add(vid3com1);
        video3._comments.Add(vid3com2);
        video3._comments.Add(vid3com3);

        
        video3.listComments();
        Console.WriteLine();

        //Video 4
        Video video4 = new Video();
        video4._title = "Running From a Spider";
        video4._author = "Jasmine Solve";
        video4._length = 125;
        _videos.Add(video4);

        //Video 4 Comments
        Comment vid4com1 = new Comment();
        vid4com1._commenter = "Jeremy Butts";
        vid4com1._comment = "Why are girls so afraid of spiders?";
        
        Comment vid4com2 = new Comment();
        vid4com2._commenter = "Kerry Melvin";
        vid4com2._comment = "Girl your scream is crazy high. Does your friend have a hearing problem now?";

        Comment vid4com3 = new Comment();
        vid4com3._commenter = "Sly Rivers";
        vid4com3._comment = "That was the smallest spider I have ever seen, Don't go to the jungle you won't survive.";

        
        video4._comments.Add(vid4com1);
        video4._comments.Add(vid4com2);
        video4._comments.Add(vid4com3);

        
        video4.listComments();
        Console.WriteLine();
        
      
        
    }
}