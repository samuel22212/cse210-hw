class Reception : Event
{

    private string _rsvpEmail;

    public Reception(string title, string desc, string date, string time, string address, string city, string state, string country, string email) : base(title, desc, date, time, address, city, state, country)
    {
        _rsvpEmail = email;
        _eventType = "Reception";
    }


    public override string GetFullDetails()
    {
        return $"{_eventType} \n" + GetStandardDetails() + $"\n RSVP at : {_rsvpEmail}.";
    }


}