public class Breathing : Activity
{

    public Breathing()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax and calm your mind as you breath in and out in a controlled session";
        _duration = 0;

    }
    public void Run()
    {
        ShowStartingMessage();
        string input = Console.ReadLine();
        _duration = int.Parse(input);
        Console.WriteLine("get Ready");
        ShowSpinner(5);
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.WriteLine();
            Console.WriteLine("breathe in... ");
            ShowCountDown(4);
            Console.WriteLine();
            Console.WriteLine("Breath out... ");
            ShowCountDown(6);
        }
        ShowEndingMessage();
        ShowSpinner(5);
    }

}