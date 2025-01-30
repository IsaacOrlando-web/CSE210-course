using System;
using OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Customer customer = new Customer();
        customer.SetName("Isaac Maldonado");
        customer.SetAddress("calle 20", "Melipilla", "Santiago", "USA");
        Console.WriteLine("Name: " + customer.GetName());
        Console.WriteLine("Address: " + customer.GetAllAddress());

        if(customer.USAorOutside() == true)
        {
            Console.WriteLine("In the USA");
        }else{
            Console.WriteLine("Outside");
        }
    }
}