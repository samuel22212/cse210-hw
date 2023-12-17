using System.Runtime.CompilerServices;

class Running : Excercise
{


    public Running(string date, int minutes, double kilometers) : base(date, minutes)
    {
        _activityType = "Running";
        _distance = kilometers;
       

    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _minutes * 60;

    }
    
}