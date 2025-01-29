using System;

class Product 
{

   private string _productName;
    private string  _productId;
    private decimal _price;
    private int _quantity;

    public Product(string productName, string productId, decimal price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal TotalCost()
    {
        return _price * _quantity;
    }

    public string PackingLabel()
    {
        return $"{_productName} Id: {_productId}";
    }
}