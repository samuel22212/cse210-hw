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
        v1.addComment("EPICTROLL", "THIS VIDEO SUX");
        v1.addComment("WorryWart33", "I hope that poor cat is okay...");
        v1.addComment("WeirdGuy1998", "I loooove cats.");
        v1.addComment("XxDaMemeBroxX", "FUNNIEST THING I'VE EVER SEEN!");

        Video v2 = new Video("Goober", "A guy says hey", 10);
        v2.addComment("Angory", "VIDEO TOO SHORT ;( ");
        v2.addComment("Angory1", "VIDEO WAY TOO SHORT ;( ");
        v2.addComment("dudeMan", "Nice Video.");
        v2.addComment("ImpatientFan11", "Nice to see you uploading again!");

        Video v3 = new Video("These Other Peoples Video's are CRAZY!", "DDDMRDOG", 312);
        v3.addComment("commenterBro", "Isn't This so and so's video?");
        v3.addComment("commenterBro", "Stop stealing people's Work!");
        v3.addComment("concernedCommenter", "BOO content theft Badd!");
        v3.addComment("EPICTROLL", "Minor spelling mistake, I win!");
        v3.addComment("OriginalUploader123", "HEY! Tha'ts my video!");

        videoList.Add(v1);
        videoList.Add(v2);
        videoList.Add(v3);

        foreach(Video v in videoList){
            counter = counter +1;
            Console.WriteLine($"Video {counter}: {v.getInformationString()}");
            Console.WriteLine($"{v.GetCommentCount()} comments.");
            Console.WriteLine();
            
        }
    }
}