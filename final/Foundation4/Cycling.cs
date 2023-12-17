using System.ComponentModel.DataAnnotations;

class Cycling : Excercise
{


    public Cycling(string date, int minutes, double Speed) : base(date, minutes)
    {   _activityType = "Cycling";
        _speed = Speed;
    }
    public override double GetDistance()
    {
        return _minutes * _speed;
    }
    public override double GetSpeed()
    {
        return _speed;

    }

}