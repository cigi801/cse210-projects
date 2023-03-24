class Expense : Budget
{

    public Expense(string budgetType, string name, double amount) : base(budgetType, name, amount)
    {

    }

    




    public override string GetBudget()
    {
        return $"{_name}: {_amount}";
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