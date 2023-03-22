class Product
{
    private string _productName;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string productName, int productID, double price, int quantity)
    {
        this._productName = productName;
        this._productID = productID;
        this._price = price;
        this._quantity = quantity;
    }

    public string GetProductName()
    {
        return productName;
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
