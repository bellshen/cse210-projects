using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();

        //Order1
        Address address1 = new Address();
        address1.SetAddress("32 West Street", "San Jose", "California", "United States");
        Customer customer1 = new Customer("Allan Paddington", address1);

        Order order1 = new Order();
        order1.SetCustomer(customer1);

        //Add Products for this order
        Product order1Product1 = new Product();
        order1Product1.SetProduct("Type C Cable", "C0198", 10.3, 2);
        order1.AddProduct(order1Product1);

        Product order1Product2 = new Product();
        order1Product2.SetProduct("1TB SSD Hard Disk", "S7369", 38.9, 1);
        order1.AddProduct(order1Product2);

        Product order1Product3 = new Product();
        order1Product3.SetProduct("Reliable Notebook", "N9937", 338.9, 1);
        order1.AddProduct(order1Product3);

        //Order2
        Address address2 = new Address();
        address2.SetAddress("99 London Street", "Melbourne", "Victoria", "Australia");
        Customer customer2 = new Customer("Christina Olson", address2);

        Order order2 = new Order();
        order2.SetCustomer(customer2);

        //Add Products for this order
        Product order2Product1 = new Product();
        order2Product1.SetProduct("USB to Lightning Cable", "L37856", 26.3,4);
        order2.AddProduct(order2Product1);

        Product order2Product2 = new Product();
        order2Product2.SetProduct("5G Phone", "P83765", 603.6,1);
        order2.AddProduct(order2Product2);

        Product order2Product3 = new Product();
        order2Product3.SetProduct("Reliable 3D Printer", "G3629", 188.9,1);
        order2.AddProduct(order2Product3);

        List<Order> orders = new List<Order> { order1, order2 };
        for (int i = 0; i < orders.Count; i++)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine($"Order{i+1}");
            orders[i].PackingLabel();
            orders[i].ShippingLabel();
            orders[i].TotalPrice();
            Console.WriteLine();
        }

    }
}