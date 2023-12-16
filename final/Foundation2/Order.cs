class Order
{

    private List<Product> _products;
    private bool _isUSBased;
    private double _shippingCost;

    public Order()
    {

        _products = new List<Product>();

    }
    public double CalculateCost()
    {
        return 0.0;

    }

    public string GetShippingLabelString()
    {
        //the shipping label should get the _NAME and _ADDRESS for the CUSTOMER;
        return "";

    }
    public string GetPackingLabelString(){
        //The packing label should get the _Name and ID of the each PRODUCT in the _PRODUCTS list. 
        return "";


    }
    public double getShippingCost()
    {

        if (_isUSBased)
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