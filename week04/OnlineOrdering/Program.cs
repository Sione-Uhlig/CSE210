using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("9000 Vantage Point Drive", "Dallas", "TX", "USA\n");
        Address address2 = new Address("9001 Markville Drive", "Dallas", "TX", "USA\n");

        Customer customer1 = new Customer("John Doe");
        Customer customer2 = new Customer("Jane Doe");



        Console.WriteLine(address1.FullAddress());
        Console.WriteLine(customer1.CustomerName());
        Console.WriteLine(new string('-', 40));

        Console.WriteLine(address2.FullAddress());
        Console.WriteLine(customer2.CustomerName());
        Console.WriteLine(new string('-', 40));
    }
}