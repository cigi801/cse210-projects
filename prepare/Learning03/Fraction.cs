class Fraction
{
    private int _nominator;
    private int _denominator;

    //Constructor with no parameters that initializes the number to 1/1
    public Fraction()
    {
        _nominator = 1;
        _denominator = 1;
    }

    //Constructor that accepts a parameter for nominator and initializes denominator to 1
    public Fraction(int wholeNumber)
    {
        _nominator = wholeNumber;
        _denominator  = 1;
    }
    
    //Constructor that accepts parameters for nominator and denominator
    public Fraction(int nominator, int denominator)
    {
        _nominator = nominator;
        _denominator = denominator;
    }

    //Method will return the fraction in fraction form
    public string GetFractionString()
    {
        string division = $"{_nominator} / {_denominator} ";
        return division;
    }

    //Method will return the decimal valuue result of dividing the numerator by the denominator
    public double GetDecimalValue()
    {
        return (double)_nominator / (double)_denominator;
    }
}