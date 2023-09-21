using System;
using System.Diagnostics.Metrics;

class CurrencyRUB : Currency
{
    public CurrencyRUB(double value) : base(value) { }

    public static implicit operator CurrencyRUB(CurrencyUSD usd)
    {
        double val = usd.value * 60;
        return new CurrencyRUB(val);
    }

    public static implicit operator CurrencyRUB(CurrencyEUR eur)
    {
        double val = eur.value * 80;
        return new CurrencyRUB(val);
    }

    public override void print()
    {
        Console.WriteLine($"{value} rub");
    }
}



class CurrencyUSD : Currency
{
    public CurrencyUSD(double value) : base(value) { }

    public static implicit operator CurrencyUSD(CurrencyRUB rub)
    {
        double val = rub.value / 60;
        return new CurrencyUSD(val);
    }

    public static implicit operator CurrencyUSD(CurrencyEUR eur)
    {
        double val = eur.value / 0.75;
        return new CurrencyUSD(val);
    }

    public override void print()
    {
        Console.WriteLine($"{value} usd");
    }
}



class CurrencyEUR : Currency
{
    public CurrencyEUR(double value) : base(value) { }

    public static implicit operator CurrencyEUR(CurrencyRUB rub)
    {
        double val = rub.value / 80;
        return new CurrencyEUR(val);
    }

    public static implicit operator CurrencyEUR(CurrencyUSD usd)
    {
        double val = usd.value * 0.75;
        return new CurrencyEUR(val);
    }

    public override void print()
    {
        Console.WriteLine($"{value} eur");
    }
}





public class Currency
{
    public double value;
    public Currency(double value)
    {
        this.value = value;
    }

    public virtual void print()
    {
        Console.WriteLine(value);
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
            CurrencyRUB rub1 = new CurrencyRUB(456.7);
            rub1.print();
            CurrencyUSD usd = rub1;
            usd.print();
            CurrencyEUR eur = usd;
            eur.print();
            CurrencyRUB rub2 = eur;
            rub2.print();
/*
            Console.WriteLine("Enter rub_eur:");
            double rub_eur =  Convert.ToDouble(Console.ReadLine());
            //double rub_eur=50.6;
            Console.WriteLine("Enter rub_usd:");
            double rub_usd = Convert.ToDouble(Console.ReadLine());*/
            
            
            //double rub_usd=45.8;
            /*double usd_eur=23.5;
            double usd_rub=98.6;
            double eur_usd=23.6;
            double eur_rub=34.7;*/


            /*CurrencyEUR eu = new CurrencyEUR(100, 84.5);
            eu.ConvertInRub(rub_eur);
            CurrencyUSD us = new CurrencyUSD(300, 97.5);
            CurrencyRUB ru = us;*/




        Console.ReadKey();

    }
}
}