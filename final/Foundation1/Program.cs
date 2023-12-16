using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {   int counter = 0;
        List<Video> videoList = new List<Video>();
        Console.WriteLine("program starting...");
        //Video: Title - Author - Length(in seconds). [note to self, learn proper method documentation]
        Video v1 = new Video("Funny Cat", "TheMemeMan", 500);
        //Comment: Author - Text
        v1.AddComment("EPICTROLL", "THIS VIDEO SUX");
        v1.AddComment("WorryWart33", "I hope that poor cat is okay...");
        v1.AddComment("WeirdGuy1998", "I loooove cats.");
        v1.AddComment("XxDaMemeBroxX", "FUNNIEST THING I'VE EVER SEEN!");

        Video v2 = new Video("A guy says hey","Goober",  10);
        v2.AddComment("Angory", "VIDEO TOO SHORT ;( ");
        v2.AddComment("Angory1", "VIDEO WAY TOO SHORT ;( ");
        v2.AddComment("dudeMan", "Nice Video.");
        v2.AddComment("ImpatientFan11", "Nice to see you uploading again!");

        Video v3 = new Video("These Other Peoples Video's are CRAZY!", "DDDMRDOG", 312);
        v3.AddComment("commenterBro", "Isn't This so and so's video?");
        v3.AddComment("commenterBro", "Stop stealing people's Work!");
        v3.AddComment("concernedCommenter", "BOO content theft Badd!");
        v3.AddComment("EPICTROLL", "Minor spelling mistake, I win!");
        v3.AddComment("OriginalUploader123", "HEY! That's my video!");

        videoList.Add(v1);
        videoList.Add(v2);
        videoList.Add(v3);

        foreach(Video v in videoList){
            counter = counter +1;
            Console.WriteLine($"Video {counter}: {v.getInformationString()}");
            Console.WriteLine($"{v.GetCommentCount()} comments.");
            Console.WriteLine("Comments: ");
            v.DisplayAllComments();
            Console.WriteLine();
        }
    }
}