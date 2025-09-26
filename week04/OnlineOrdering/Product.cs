public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;

    public void SetProduct(string productName, string productID, double price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public void Display()
    {
        Console.WriteLine($"Product Name: {_productName} , Product ID: {_productID} ");
        Console.WriteLine($"Price: ${_price} * Quantity: {_quantity}");
        Console.WriteLine($"Total Cost: ${TotalCost()}");
        Console.WriteLine();
    }
    public double TotalCost()
    {
        return _price * _quantity;
    }
}