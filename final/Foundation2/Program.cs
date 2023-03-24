using System;

class Program
{
    static void Main(string[] args)
    {   
        //Create Customers
        Address address1 = new Address("154 Main St.", "Winner", "Montana", "USA");
        Customer customer1 = new Customer("Sally Randel", address1);
        
        Address address2 = new Address("1254 W 105th st.", "Adams", "Oregan","USA");
        Customer customer2 = new Customer("Mitch Turner",address2);

        Address address3 = new Address("988 Hawthorn Rd.", "North Falls", "Ontario", "CANADA");
        Customer customer3 = new Customer("Wonda Kind", address3);

//Create Products
        Product product1 = new Product("Paper Towel", "23956", 1.59, 3);
        Product product2 = new Product("Dish Soap", "18954", 5.49, 1);
        Product product3 = new Product("Laudry Pods", "56742", 13.99, 1);
        Product product4 = new Product("Toilet Paper", "65897", 12.99, 2);
        Product product5 = new Product("Stain Remover", "41247", 3.79, 1);
        Product product6 = new Product("Dishwasher Pods", "95641", 17.99, 1);

// Create first order
        Order order1 = new Order(new List<Product>{product1, product2, product3},customer1);
        //order1.Prod.Add(product1);
        //order1.Prod.Add(product2);
        //order1.Prod.Add(product3);

// Create Second Order
        Order order2 = new Order(new List<Product>{product3, product4, product6},customer2);
        //order2.Prod.Add(product3);
        //order2.Prod.Add(product4);
        //order2.Prod.Add(product6);

//Create third Order
        Order order3 = new Order(new List<Product>{product1, product5, product3},customer3);

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total:{ order1.TotalCost():C}");
        Console.WriteLine();

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total:{ order2.TotalCost():C}"); 
        Console.WriteLine();     

        Console.WriteLine(order3.PackingLabel());
        Console.WriteLine(order3.ShippingLabel());
       Console.WriteLine($"Total:{ order3.TotalCost():C}"); 

         
        

        //order1.GetOrder(); 
        //order1.TotalCost();
        
    }
}   //create two orders with 3 products
        // call methods to get packing label
        //call method to get shipping label
        // total price of of order