class Customer{

private string _name;
private Address _address; 
public Customer(string name, string address, string city, string state, string country){

    _name = name;
    _address = new Address(address,city,state,country);

}
public string GetAddressForLabel(){

    return _address.GetAddressString();
}
public bool IsUSACustomer(){
return _address.IsUSA();
}
public string GetName(){

    return _name;
}

    
}