abstract class Goal{

    protected string _name;
    protected string _description;
    protected int _points;
public Goal(string name, string description, int points)
{
_description = description;
_name = name;
_points = points;

}
public abstract bool IsComplete();
public virtual string GetDeatilsString(){
if (IsComplete()==true){
    string details = $"[x] {_name} ({_description})";
    return details;
}
else{
    string details =$"[ ] {_name} ({_description})";
    return details;
}
//need to be overriden for Checklist Goal.
//The code for this was flowing so naturally and then I hit this method and It's like a brick wall. How do I do this and How do I override it? 
}
}