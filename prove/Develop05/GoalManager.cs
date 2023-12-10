using System.Security.Cryptography.X509Certificates;

class GoalManager
{

    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {

        _goals = new List<Goal>();
        _score = 0;
    }

    public int GetScore()
    {
        return _score;
    }
    public void CreateGoal(int type)
    // This feels wrong and bad. But It'll do for now I guess. 
    {

        if (type == 1)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Please describe this goal: ");
            string description = Console.ReadLine();
            Console.WriteLine("How many Points should this goal be worth each time?");
            int points = int.Parse(Console.ReadLine());
            EternalGoal eternal = new EternalGoal(name, description, points);
            _goals.Add(eternal);
            Console.WriteLine("Goal Added Sucessfully");

        }
        else if (type == 3)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Please describe this goal: ");
            string description = Console.ReadLine();
            Console.WriteLine("How many Points should each step be worth?");
            int points = int.Parse(Console.ReadLine());
            Console.WriteLine("How many steps are there to complete for this goal? ");
            int steps = int.Parse(Console.ReadLine());
            Console.WriteLine("How many bonus points should be awarded for completing all steps? ");
            int bonusPoints = int.Parse(Console.ReadLine());
            CheckListGoal checklist = new CheckListGoal(name, description, points, steps, bonusPoints);
            _goals.Add(checklist);
            Console.WriteLine("Goal Added Sucessfully");

        }
        else
        {
            string name = Console.ReadLine();
            Console.WriteLine("Please describe this goal: ");
            string description = Console.ReadLine();
            Console.WriteLine("How many Points should this goal be worth?");
            int points = int.Parse(Console.ReadLine());
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
            Console.WriteLine("Goal Added Sucessfully.");
        }


    }
    public void ViewGoals(){
        foreach (Goal g in _goals)
        {
            Console.WriteLine(g.GetDeatilsString());

        }


    }
}