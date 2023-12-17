abstract class Event
{

    protected string _eventTitle;
    private string _description;
    protected string _date;
    private string _time;
    private Address _address;
    protected string _eventType;
    public Event(string title, string desc, string date, string time, string address, string city, string state, string country)
    {
        _eventType = "Event";
        _eventTitle = title;
        _description = desc;
        _date = date;
        _time = time;
        _address =  new Address(address,city,state,country);

    }
    //basic information about the event. 
    public virtual string GetStandardDetails()
    {

        return $"-{_eventTitle}-\n {_description} \n Address: {_address.GetAddressString()} \n Date: {_date} | {_time}";

    }
    //All of GetStandard Details plus additonal information depending on the event
    public abstract string GetFullDetails();

    //type of event, title, date
    public virtual string GetShortDescription()
    {
        return $"{_eventType} \n {_eventTitle} \n Date: {_date}";

    }

}