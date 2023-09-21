using System;
using System.Diagnostics.Metrics;

class CurrencyRUB : Currency
{
    public CurrencyRUB(int value, double cent) : base(value, cent)
    {
    }
}
class CurrencyUSD : Currency
{
    public CurrencyUSD(int value, double cent) : base(value, cent)
    {
        
    }

    public static explicit operator CurrencyRUB(CurrencyUSD us)
    {
        return new CurrencyRUB { cent = us.ConvertInRub() };
    }
}
class CurrencyEUR : Currency
{
    public CurrencyEUR(int value, double cent) : base(value, cent)
    {
    }
}


public abstract class Currency
{
    public double cent;
    public double value;
    double amount_in_rub;
    //double amount_in_eur;
    //double amount_in_usd;
    public Currency(double value, double cent)
    {
        this.cent = cent;
        this.value = value;
    }

    public double ConvertInRub()
    {
        amount_in_rub = cent * value;
        Console.WriteLine($"Перевод в рубли:{amount_in_rub}");
        return amount_in_rub;
    }

   
    /*public double ConvertInEur(double amount, double value)
    {
        amount_in_rub = amount * value;
        Console.WriteLine($"Перевод в евро:{amount_in_eur}");
        return amount_in_eur;
    }
    public double ConvertInUsd(double amount, double value)
    {
        amount_in_rub = amount * value;
        Console.WriteLine($"Перевод в долары:{amount_in_usd}");
        return amount_in_usd;
    }*/

}



namespace part3
{
    class program
{
    static void Main(string[] args)
    {
            CurrencyEUR eu = new CurrencyEUR(100, 84.5);
            eu.ConvertInRub();



        Console.ReadKey();

    }
}
}