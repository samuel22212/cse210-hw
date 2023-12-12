using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

class CheckListGoal : Goal
{   // This is the int variable that gets returned to the Goalie.
    // as opposed to the points variable that determines the points each step is worth which is inherited. 
    private int point = 0;
    private int _amountCompleted;
    private int _target;
    private int _bonusPoints;
    public CheckListGoal(string name, string description, int points, int amountSteps, int bonusPoints) : base(name, description, points)
    {

        _amountCompleted = 0;
        _target = amountSteps;
        _bonusPoints = bonusPoints;
    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override void RecordEvent()
    {
        Console.WriteLine("Please enter the amount of steps you completed: ");
        int amountThisTime = int.Parse(Console.ReadLine());
        point = amountThisTime * _points;
        _amountCompleted = _amountCompleted + amountThisTime;
       Console.WriteLine($"Congratulations, You Scored {point} points!");
        if(IsComplete()){
            Console.WriteLine($"You also scored {_bonusPoints} points for completeing all steps! Good Job.");
            point = point + _bonusPoints;
        }
        
    }
    public override int GetPoints()
    {
        return point;
    }
    public override string GetDeatilsString()
    {

        string details = $"|{_name}| {_description} | Steps Completed: {_amountCompleted}/{_target}";
        return details;

    }




}