using System;
class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);
        // Create products
        Product product1 = new Product("Soccer Ball", "P001", 20.50m, 2);
        Product product2 = new Product("Jersey", "P002", 35.75m, 1);
        Product product3 = new Product("Goal Net", "P003", 120.00m, 1);
        Product product4 = new Product("Cleats", "P004", 75.00m, 2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);


        // display orders

        Console.WriteLine(order1.GetPackLabel());
        Console.WriteLine(order1.GetShipLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");


        Console.WriteLine(order2.GetPackLabel());
        Console.WriteLine(order2.GetShipLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}\n");

    }
}