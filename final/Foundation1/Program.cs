using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Cat drives its owner to the hospital", "Beverly.Manadoo573", 8);
        Comment comment1 = new Comment("Jan", "The video cut out before you even left your driveway");
        video1.AddComment(comment1);
        Comment comment2 = new Comment("Gary", "That was a waste of 8 seconds..");
        video1.AddComment(comment2);
        Comment comment3 = new Comment("The Cat", "Take this video down Deborah!");

        Video video2 = new Video("Lipsyncing 'Baby Shark'", "Phil Collins", 3256);
        Comment comment4 = new Comment("Phyllis", "I could watch you all day Phil");
        video2.AddComment(comment4);
        Comment comment5 = new Comment("LipsyncingNinja", "You think this video is good, come watch me lipsync the gummy bear song!");
        video2.AddComment(comment5);
        Comment comment6 = new Comment("Florence", "I was trying to search 'how to crochet a baby blanket', how do I leave this video? I'm stuck. Phil, can you please stop singing and show me how to crochet a baby blanket? My neighbor Margerie made one and now I need to make one    ");
        video2.AddComment(comment6);

        Video video3 = new Video("How to teach your pet rat to cook", "Alfredo Linguini", 22);
        Comment comment7 = new Comment("Remy", "This should be called 'How to teach your human to cook'");
        video3.AddComment(comment7);
        Comment comment8 = new Comment("Emile", "Hey! I know that rat!");
        video3.AddComment(comment8);
        Comment comment9 = new Comment("Alfredo Linguini", "Remy! Buddy! Of course that's what I meant...");
        video3.AddComment(comment9);
        
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        video1.DisplayVideo();

        video2.DisplayVideo();

        video3.DisplayVideo();



    }
}


