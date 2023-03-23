class Customer
{
    protected string _customerName;
    protected Address _address;

    public Customer(string customerName, Address address)
    {
        this._customerName = customerName;
        this._address = address;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool InUSA()
    {
        return Address.IsUSA;
    }
}
