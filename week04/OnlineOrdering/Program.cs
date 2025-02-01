using System;
using OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {

        Customer customer = new Customer();
        customer.SetName("Juan Pedro");
        customer.SetAddress("Santa Gloria", "Melipilla", "Santiago", "USA");

        Order order = new Order();
        order.SetCustomer(customer);
        order.AddProdutc("Xbox 360", "123432", 2.30, 1);
        order.AddProdutc("Nintendo 64", "19283ju", 2.30, 3);
        order.AddProdutc("Nintendo DS", "YU-09878-HY", 3.200, 10);
        Console.WriteLine(order.ShippingLabel());
        Console.WriteLine(order.PackingLabel());
        Console.WriteLine($"Total Price: {order.TotalPrice()}");

        Customer customer2 = new Customer();
        customer2.SetName("Brigham Maldonado");
        customer2.SetAddress("Angola", "Lima", "santa Fe", "Peru");

        Order order2 = new Order();
        order2.SetCustomer(customer2);
        order2.AddProdutc("Goku Figure", "HJ-98-D", 30.2, 3);
        order2.AddProdutc("Naruto RETRO VHS", "HJ-09-W", 100.0, 1);
        order2.AddProdutc("Anime Shirts", "HJ-08-ET-O", 1.00, 4);
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine($"Total Price: {order2.TotalPrice()}");

        Customer customer3 = new Customer();
        customer3.SetName("Juan Alvarez");
        customer3.SetAddress("San Martin", "CDMX", "CDMX", "Mexico");

        Order order3 = new Order();
        order3.SetCustomer(customer3);
        order3.AddProdutc("Nietzche's Works Collection", "YD-09-G", 20.0, 2);
        order3.AddProdutc("Dragon Ball z DVD Fan Collection", "2-rg-32", 100.0, 3);
        order3.AddProdutc("Anime Shirts", "HJ-08-ET-O", 1.00, 4);
        Console.WriteLine(order3.ShippingLabel());
        Console.WriteLine(order3.PackingLabel());
        Console.WriteLine($"Total Price: {order3.TotalPrice()}");
    }
}