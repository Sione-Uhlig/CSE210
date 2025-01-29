using System;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal TotalPrice()
    {
        return _products.Sum(product => product.TotalCost()) + (_customer.IsInUSA() ? 5 : 35);
    }

    public string PackingLabel()
    {
        List<string> labels = new List<string>();
        foreach (var product in _products)
        {
            labels.Add(product.PackingLabel());
        }
        return string.Join("\n", labels);
    }

    public string ShippingLabel()
    {
        return _customer.ShippingLabel();
    }


}