using System.Net.Security;

class Address
{

    private string _address;
    private string _city;
    private string _state_prov;
    private string _country;



    public Address(string street, string city, string state, string country)
    {
        _address = street;
        _city = city;
        _state_prov = state;
        _country = country;

    }
/*public bool IsUSA()
    {

        if (_country == "United States" || _country == "US" || _country == "United States of America" || _country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
  }  */
    public string GetAddressString()
    {

        return $"{_address} \n {_city}, {_state_prov} \n {_country}";

    }

}