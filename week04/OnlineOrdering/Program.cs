using System;

class Program
{
    static void Main(string[] args)
    {
         // Create customers and addresses
        Address address1 = new Address("1296 B Section", "Botshabelo", "Free State", "RSA");
        Customer customer1 = new Customer("Marry Jones", address1);

        Address address2 = new Address("1392 U Section", "Botshabelo", "Free State", "RSA");
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders and products
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("IPhone12", "APL001", 3.00m, 5));
        order1.AddProduct(new Product("IPad", "BAN001", 1.00m, 10));
        order1.AddProduct(new Product("Screen", "ORG001", 2.00m, 7));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Shoes", "GRP001", 4.00m, 3));
        order2.AddProduct(new Product("T shirt", "PIN001", 5.00m, 2));
        order2.AddProduct(new Product("Hat", "WAT001", 6.00m, 1));

        // Display order information
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}