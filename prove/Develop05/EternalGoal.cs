class EternalGoal : Goal
{

    // no member variables needed
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
        Console.WriteLine("Congratulations on your progress with this goal! keep working hard");
        Console.WriteLine($"You have scored {_points} points.");
    }
    public override int GetPoints()
    {
        return _points;
    }
    public override bool IsComplete()
    {
        return false;
    }
}