class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        this._customerName = customerName;
        this._address = address;
    }

    public string GetCustomerName()
    {
        return customerName;
    }

    public Address GetAddress()
    {
        return address;
    }

    public bool InUSA()
    {
        return Address.IsUSA;
    }
}
