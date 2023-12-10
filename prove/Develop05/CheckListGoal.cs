using System.ComponentModel;

class CheckListGoal : Goal{
private int _amountCompleted;
private int _target;
private int _bonusPoints;
public CheckListGoal(string name, string description, int points, int amountSteps, int bonusPoints):base(name,description,points){

_amountCompleted = 0;
_target = amountSteps;
_bonusPoints = bonusPoints;


}
public override string GetDeatilsString()
{



}




}