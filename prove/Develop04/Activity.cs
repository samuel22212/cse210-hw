using System.ComponentModel;

public class Activity
{

    public Activity()
    {
        _name = "";
        _duration = 0;
        _description = "";
    }
    protected string _name;
    protected int _duration;
    protected string _description;

    public void ShowStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.WriteLine("How long would you like this session to be in seconds? ");
    }
    public void ShowEndingMessage()
    {

        Console.WriteLine("Well Done! I knew you could do it.");
        Console.WriteLine();
        Console.WriteLine($"You Have completed {_duration} seconds of the {_name}. ");
        //Thread.Sleep(1000);

    }
    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endtime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endtime)
        {
            List<char> animationFrames = new List<char>();
            animationFrames.Add('\\');
            animationFrames.Add('|');
            animationFrames.Add('/');
            animationFrames.Add('-');
            animationFrames.Add('\\');
            animationFrames.Add('|');
            animationFrames.Add('-');
            char c = animationFrames[i];
            Console.Write(c);
            Thread.Sleep(50);
            Console.Write("\b \b");
            i++;
            if (i >= animationFrames.Count())
            {
                i = 0;
            }
        }

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
        }
    }


}