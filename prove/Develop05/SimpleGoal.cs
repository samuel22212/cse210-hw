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
    //basically a setter
    public void completeGoal(){
    _isComplete = true;

}

}