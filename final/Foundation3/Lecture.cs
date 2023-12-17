using System.Runtime.CompilerServices;

class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string desc, string date, string time, string address, string city, string state, string country, string speaker, int capacity) : base(title, desc, date, time, address,city,state,country)
    {
        _speaker = speaker;
        _eventType = "Lecture";
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        
        return$"{_eventType} \n" + GetStandardDetails() +  $"\n Event Speaker: {_speaker} \n Capacity: {_capacity}. ";
    }


}