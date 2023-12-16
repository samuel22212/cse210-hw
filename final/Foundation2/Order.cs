using System.Xml.Schema;

class Order
{

    private List<Product> _products;
    private double _shippingCost;
    private Customer _customer;
    private double _total;
    private string _packingLabel;
    public Order()
    {

        _products = new List<Product>();

    }
    public void SetCustomer(string name, string address, string city, string state, string country){

        _customer = new Customer(name, address,city,state,country);

    }
    public double CalculateCost()
    {
        foreach (Product p in _products)
        {
            _total = _total + p.GetProductPrice();
        }
        _total = _total + GetShippingCost();

        return Math.Round(_total,2);
    }

    public string GetShippingLabelString()
    {
        //the shipping label should get the _NAME and _ADDRESS for the CUSTOMER;
        return $"{_customer.GetName()} \n {_customer.GetAddressForLabel()}";
    }
    public string GetPackingLabelString()
    {
        //The packing label should get the _Name and ID of the each PRODUCT in the _PRODUCTS list. 
        
        _packingLabel = "";
        foreach(Product P in _products){
            _packingLabel = _packingLabel + P.GetNameandID();
        }
        return _packingLabel;
    }
    public void AddProduct(string name, string id, double price, int quantity)
    {
        Product p = new Product(name, id, price, quantity);
        _products.Add(p);

    }
    public double GetShippingCost()
    {

        if (_customer.IsUSACustomer())
        {
            _shippingCost = 5.00;

        }
        else
        {
            _shippingCost = 35.00;
        }
        return _shippingCost;
    }

}