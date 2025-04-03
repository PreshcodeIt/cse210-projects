using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating customers
        Customer customer1 = new Customer("Alice Johnson", new Address("123 Main St", "New York", "NY", "USA"));
        Customer customer2 = new Customer("Bob Smith", new Address("456 Maple Rd", "Toronto", "Ontario", "Canada"));

        // Creating orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P123", 1200, 1));
        order1.AddProduct(new Product("Mouse", "P456", 25, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "P789", 300, 1));
        order2.AddProduct(new Product("Keyboard", "P101", 50, 1));

        // Storing orders in a list
        List<Order> orders = new List<Order> { order1, order2 };

        // Displaying order information
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}\n");
        }
    }
}
