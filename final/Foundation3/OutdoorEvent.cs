class OutdoorEvent : Event
{
    private string _weather;
    public OutdoorEvent(string title, string desc, string date, string time, string address, string city, string state, string country,string weather) : base(title, desc, date, time, address, city, state, country)
    {
        _weather = weather;
        _eventType = "OutDoor Event";


    }

    public override string GetFullDetails()
    {
        return $"{_eventType} \n" + GetStandardDetails() + $"\n Weather:{_weather}."; 
    }


}