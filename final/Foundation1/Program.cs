//Foundation 1, Abstraction
class Program
{
    static void Main(string[] args)
    {
        //Video 1
        Video video1 = new("A brief intro to Ancient Lore", "Alice",28800);
        video1.AddComment("Ashley","Why did you make it this long? You could've halved the runtime.");

        video1.AddComment("Brite","First");
        video1.AddComment("Jim","Another example of the AAA industry's failings. Wait wrong video");
        
        //Video 2
        Video video2 = new("How to deal with overwhelming Stress", "Brite",300);
        video2.AddComment("Ashley","Are you really the best person to talk about this?");
        video2.AddComment("Luna","Instructions unclear, cat laying on keyboard.");
        video2.AddComment("Alice","Deja vu...");
        video2.AddComment("Jim","This time it's a real example of the AAA industry's failings. Wait wrong video again sorry.");
        
        //Video 3
        Video video3 = new("Character Writing Tips", "Dess",333);
        video3.AddComment("Brite","So, its okay if the eyes glow...");
        video3.AddComment("YoshiP","@Brite it's a requirement.");
        video3.AddComment("Kalissa","@Brite always was.");
        video3.AddComment("Luna","Okay, but it doesn't feel spontaneous enough. Fell asleep.");
        video3.AddComment("StealtMuffin","Wait, how did I get here? I mean thanks but wha?");
        video3.AddComment("Jim","Finally, another- wait autoplay already changed it?");
        
        //Video 1
        Video video4 = new("Tips on Living a Healthy Life in Dark Times", "Jim",137);
        video4.AddComment("Rook","Hardly a fair comparison.");
        video4.AddComment("Ashley","Enlightening, I know someone who needs this");
        video4.AddComment("Jim","This still isn't the right video but it's helping me stay positive.");
        
        //Display each video info and coments.
        video1.Display();
        video1.PrintAllComments();
        video2.Display();
        video2.PrintAllComments();
        video3.Display();
        video3.PrintAllComments();
        video4.Display();
        video4.PrintAllComments();
    }
}