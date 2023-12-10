using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class CheckListGoal : Goal
{
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

    public override string GetDeatilsString()
    {

        string details = $"{_name} {_description} | Steps Completed: {_amountCompleted}/{_target}";
        return details;

    }




}