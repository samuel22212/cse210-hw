class Product{

private string _productName;
private string _id;
private double _price;
private int _quantity;

public Product(string name, string id, double price, int quantity){

_productName = name;
_id = id;
_price = price; 
_quantity = quantity;

}
public double GetProductPrice()
{
  return _price * _quantity; 

}

public string GetNameandID(){

  return $"({_quantity}) {_productName} | Product ID: {_id} \n";
}
    
}