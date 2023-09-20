using System;

class CurrencyUSD : Currency
{
    public CurrencyUSD(int value) : base(value)
    {
    }
}
class CurrencyEUR : Currency
{
    public CurrencyEUR(int value) : base(value)
    {
    }
}

class CurrencyRUB : Currency
{
    public CurrencyRUB(int value) : base(value)
    {
    }
}
public class Currency
{
    int Value;
    public Currency(int value) { this.Value = value; }
}



namespace part3
{
    class program
{
    static void Main(string[] args)
    {

        Console.ReadKey();

    }
}
}