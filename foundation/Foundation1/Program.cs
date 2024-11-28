using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!\n");

        Video video1 = new Video("Neymar's Top 10 Goals", "Soccer Channel", 5, 30);
        Video video2 = new Video("Brazil's World Cup Moments", "Football History", 8, 15);
        Video video3 = new Video("The Art of Dribbling - Neymar Special", "Skills Master", 4, 50);

        // Add comments to video 1
        video1.AddComment(new Comment("John", "Neymar is an incredible player!"));
        video1.AddComment(new Comment("Maria", "Amazing goals, he’s so talented."));
        video1.AddComment(new Comment("Lucas", "Love watching him play!"));

        // Add comments to video 2
        video2.AddComment(new Comment("Anna", "Brazil always plays with so much passion!"));
        video2.AddComment(new Comment("Carlos", "Their World Cup history is unmatched."));
        video2.AddComment(new Comment("Sophie", "Great video, learned so much!"));

        // Add comments to video 3
        video3.AddComment(new Comment("Pedro", "Neymar’s dribbling skills are out of this world."));
        video3.AddComment(new Comment("Julia", "I’m inspired to practice my dribbling now!"));
        video3.AddComment(new Comment("Marco", "Best Neymar skills compilation ever!"));

        List<Video> videos= new List<Video>{ video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDysplayText());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.GetDysplayText());
            }
            Console.WriteLine();
        }

    }
}