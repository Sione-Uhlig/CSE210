using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("9000 Vantage Point Drive", "Dallas", "TX", "USA");
        Address address2 = new Address("9001 Markville Drive", "Dallas", "TX", "Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Doe", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Airpods", "P123", 134.98m, 2));
        order1.AddProduct(new Product("Kitchen Scale", "P132", 11.49m, 1));
        order1.AddProduct(new Product("72 Color Colored Pencils", "P125", 8.99m, 5));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Airpods", "P123", 134.98m, 1));
        order2.AddProduct(new Product("Stainless steel water bottle", "P125", 10.99m, 5));
        


        Console.WriteLine("\nOrder 1");
        Console.WriteLine("Packing Label:\n" + order1.PackingLabel() + "\n");
        Console.WriteLine("Shipping Label:\n" + order1.ShippingLabel() + "\n");
        Console.WriteLine("Total Price: $" + order1.TotalPrice());
        Console.WriteLine(new string('-', 40));
       

        Console.WriteLine("\nOrder 2");
        Console.WriteLine("Packing Label:\n" + order2.PackingLabel() + "\n");
        Console.WriteLine("Shipping Label:\n" + order2.ShippingLabel() + "\n");
        Console.WriteLine("Total Price: $" + order2.TotalPrice());
        Console.WriteLine(new string('-', 40));
      
    }
}