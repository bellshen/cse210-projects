public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool LiveInUSA()
    {
        return _address.IsUSA();
    }
    public void Display()
    {
        Console.WriteLine($"Customer Name: {_name}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
    }
}