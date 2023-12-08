public class Listing : Activity
{

    private List<string> _prompts = new List<string>();
    private List<string> _responses = new List<string>();
    private int _responseNumber = 0; 
    public Listing()
    {
        _name = "Listing Activity";
        _description = "This activity will help you ground yourself focus as you list things from a question prompt.";
        _duration = 0;
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        _prompts.Add("What are some of your favorite things in the world?");

    }
    public void run()
    {   //extra writelines from double spacing i just think it looks nicer. 
        ShowStartingMessage();
        string input = Console.ReadLine();
        _duration = int.Parse(input);
        Random rand = new Random();
        int randy = rand.Next(1, _prompts.Count - 1);
        Console.WriteLine();
        Console.WriteLine("please make a list of the following...");
        Console.WriteLine();
        Console.WriteLine($"---{_prompts[randy]}---");
        Console.WriteLine();
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);
        Console.WriteLine("Get ready");
        ShowSpinner(5);
        while (DateTime.Now < end){
            input = Console.ReadLine();
            _responses.Add(input);
            _responseNumber ++; 
        }
        Console.WriteLine();
        Console.WriteLine($"You recorded {_responseNumber} items.");
        ShowEndingMessage();
        ShowSpinner(8);

    }

}