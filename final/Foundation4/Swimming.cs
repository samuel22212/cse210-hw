class Swimming : Excercise{

    private int _laps; 
    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {   _activityType = "swimming"; 
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance()/_minutes*60;

    }
    
}