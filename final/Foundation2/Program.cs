using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Order order1 = new Order();
        order1.SetCustomer("William Robert", "123 Main St","Springfield","UT","USA");
        order1.AddProduct("Shampoo", "ARG20219",2.99,1);
        order1.AddProduct("Conditioner", "CND11392",3.99,1);
        order1.AddProduct("Frozen Waffles", "KEL0199",5.00,4);
        order1.AddProduct("Bread", "BRD22212",1.50,1);
        Console.WriteLine("Order 1 Packing Label");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine(order1.GetPackingLabelString());
        Console.WriteLine();
        Console.WriteLine("Order 1 Shipping Label");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine(order1.GetShippingLabelString());
        Console.WriteLine();
        Console.WriteLine($"Order 1 Total: ${order1.CalculateCost()}");

        Order order2 = new Order();
        order2.SetCustomer("Helda Smith","49921 W Baker St", "Stockholm", "Stockholm Province", "Sweden");
        order2.AddProduct("Windex", "GLD4231",6.89,1);
        order2.AddProduct("RAG", "RT53282",0.99,5);
        Console.WriteLine("Order 2 Packing Label");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine(order2.GetPackingLabelString());
        Console.WriteLine();
        Console.WriteLine("Order 2 Shipping Label");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine(order2.GetShippingLabelString());
        Console.WriteLine();
        Console.WriteLine($"Order 2 Total: ${order2.CalculateCost()}");
    }
}