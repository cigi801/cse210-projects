class Order
{
    protected List<Product> _products;
    protected Customer _customer;

    public Order(Customer customer)
    {
        this._products = new List<Product>();
        this._customer = customer;
    }

    public void AddProduct()
    {
        this._products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach(Product p in _products)
        {
            total += p.GetPrice();
        }
        if (Customer.GetAddress().IsUSA())
        {
            total += 5.0;
        }
        else
        {
            total += 35.0;
        }
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing label: \n";
        foreach(Product p in _products)
        {
            label += p.GetProductName() + p.GetProductID();
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping label: \n";
        label += Customer.GetCustomerName();
        label += Customer.GetAddress().ToString();
        return label;
    }


}
