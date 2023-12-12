using System.Security.Cryptography.X509Certificates;

class SimpleGoal : Goal{

private bool _isComplete;

public SimpleGoal(string name, string description, int points):base(name,description,points)
{
_isComplete = false;

}
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override int GetPoints()
    {
        return _points;
    }
    public override void RecordEvent(){
    _isComplete = true;
    Console.WriteLine($"Congratulations, You Scored {_points} points!");
    
    
}

}