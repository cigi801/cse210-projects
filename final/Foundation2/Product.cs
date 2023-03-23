class Product
{
    protected string _productName;
    protected string _productID;
    protected double _price;
    protected int _quantity;

    public Product(string productName, string productID, double price, int quantity)
    {
        this._productName = productName;
        this._productID = productID;
        this._price = price;
        this._quantity = quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public double GetPrice()
    {
        return _price * _quantity;
    }




}
