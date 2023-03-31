//Parent class Budget

class Budget
{
    protected string _name;
    protected double _amount;



    public Budget()
    {

    }


    public Budget(string name, double amount)
    {
        this._name = name;
        this._amount = amount;
    }



    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public double GetAmount()
    {
        return _amount;
    }


    public void SetAmount(double amount)
    {
        _amount = amount;
    }
   



    public string GetBudget()
    {
        return $"{_name}: ${_amount}";
    }



}