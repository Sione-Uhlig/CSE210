using System;

class Customer
{
    private string _customerName;

    public Customer(string customerName)
    {
        _customerName = customerName;
    }

    public string CustomerName()
    {
        return $"{_customerName}"; 
    }
}