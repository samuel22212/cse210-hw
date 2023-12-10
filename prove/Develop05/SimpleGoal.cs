class SimpleGoal : Goal{

private bool _isComplete;

public SimpleGoal(string name, string description, int points):base(name,description,points)
{
_isComplete = false;


}
//basically a setter
public void completeGoal(){
    _isComplete = true;

}

}