public class Reflecting : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public Reflecting()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect by giving you time to search your mind for the answers to a few questions.";
        _duration = 0;
        //questions
        _questions.Add("How did you feel about the activity?");
        _questions.Add("Was there a specific person you thought of while reflecting?");
        //prompts
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a person who has helped you throughout your life.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _prompts.Add("Think of your happiest memory");
    }
    public void run()
    {

        ShowStartingMessage();
        string input = Console.ReadLine();
        _duration = int.Parse(input);
        Random rand = new Random();
        int randy = rand.Next(1, _prompts.Count - 1);
        Console.WriteLine("get Ready");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt.");
        Console.WriteLine();
        Console.WriteLine($"---{_prompts[randy]}---");
        _prompts.RemoveAt(randy);
        Console.WriteLine("\nWhen you have something in mind, Press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("reflect on the following...");
        ShowSpinner(5);
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Random r = new Random();
            randy = r.Next(1, _questions.Count() - 1);
            Console.WriteLine();
            Console.WriteLine(_questions[randy]);
            _questions.RemoveAt(randy);
            ShowSpinner(10);
            if (_questions.Count() <= 2)
            {
                _questions.Add("How did you feel about the activity?");
                _questions.Add("Was there a specific person you thought of while reflecting?");
                _questions.Add("What might you do to achieve your goals this week?");
                _questions.Add("Are you feeling okay right now?");
                _questions.Add("How can you keep this experience in mind in the future?");
                _questions.Add("Why was this experience meaningful to you?");
                _questions.Add("Have you ever done anything like this before?");
                _questions.Add("How did you get started?");
                _questions.Add("What is your favorite thing about this experience?");
                _questions.Add("What did you learn about yourself through this experience?");
            }
        }
        Console.WriteLine();
        ShowEndingMessage();
        ShowSpinner(8);


    }



}