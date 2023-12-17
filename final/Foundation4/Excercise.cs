using System.Data;

abstract class Excercise
{
    //Metric system measurements
    private string _date;
    protected int _minutes;
    protected string _activityType;
    protected double _pace;
    protected double _distance;
    protected double _speed;
    public Excercise(string date, int minutes)
    {

        _date = date;
        _minutes = minutes;

    }
    public abstract double GetDistance();

    public abstract double GetSpeed();

    public virtual string GetPace(){

        {
        _pace = 60 / GetSpeed();
        return $"{_pace} minutes per km";
    }
    }

    public string GetSummary()
    {

        return $"{_date} {_activityType} ({_minutes} minutes)- Distance: {GetDistance()}km, Speed: {GetSpeed()}kph Pace: {GetPace()}. ";

    }
}