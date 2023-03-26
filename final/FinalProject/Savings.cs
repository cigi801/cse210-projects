
class Savings : Budget
{

    public Savings(string budgetType, string name, double amount) : base(budgetType, name, amount)
    {

    }


    public override string GetBudget()
    {
        return $"{_name}: {_amount}";
    }

    public override string GetBudgetLine()
    {
        string budget = $"{base._budgetType},{base._name},{base._amount}";
        return budget;
    }

    public override string GetBudgetType()
    {
        return _budgetType;
    }

    public override string GetName()
    {
        return _name;
    }

    public override double GetAmount()
    {
        return _amount;
    }

     public override void SetAmount(double amount)
    {
        _amount = amount;
    }


}