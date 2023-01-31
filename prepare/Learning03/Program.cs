using System;

class Program
{
    static void Main(string[] args)
    {
        //setter
         Fraction noParam = new Fraction();
        //getters
         Console.WriteLine(noParam.GetFractionString());
         Console.WriteLine(noParam.GetDecimalValue());

        //setter
        Fraction wholeNum = new Fraction(12);
        //getters
        Console.WriteLine(wholeNum.GetFractionString());
        Console.WriteLine(wholeNum.GetDecimalValue());

        //setter
        Fraction twoParams = new Fraction(3, 2);
        //getters
        Console.WriteLine(twoParams.GetFractionString());
        Console.WriteLine(twoParams.GetDecimalValue());

    }

}