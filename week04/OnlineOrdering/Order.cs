using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private double _shipping;

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalPrice()
    {
        double _sum = 0;
        foreach (Product product in _products)
        {
            _sum += product.TotalCost();
        }
        _shipping = _customer.LiveInUSA() ? 5 : 35;

        double _totalPrice = _sum + _shipping;

        Console.WriteLine($"Shipping Price: ${_shipping}");
        Console.WriteLine($"Total Price of the Order: ${_totalPrice}");
        return _totalPrice;
    }

    public void PackingLabel()
    {
        Console.WriteLine("<<Packing Label>>");
        foreach (Product product in _products)
        {
            product.Display();
        }
        Console.WriteLine();
    }
    public void ShippingLabel()
    {
        Console.WriteLine("<<Shipping Label>>");
        _customer.Display();
        Console.WriteLine();
    }

}