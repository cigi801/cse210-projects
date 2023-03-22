using System;

class Program
{
    static void Main(string[] args)
    {
        
        Product product1 = new Product("Glacier Glasses", 1, 142.50, 1);
        Product product2 = new Product("Crampons", 2, 180.99, 1);
        Product product3 = new Product("Ice Axe", 3, 198.99, 1);
        Product product4 = new Product("Winter Mittens", 4, 99.98, 1);

        Address address1 = new Address("210 N Main", "New Orleans", "LA", "USA");

        Customer customer1 = new Customer("John Jingleheimer", address1);


        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: $ {order1.GetTotalPrice()}");

    }
}
