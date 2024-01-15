class Currency
{
    public double Value { get; set; }
}
class CurrencyUSD : Currency
{
    public static explicit operator CurrencyEUR(CurrencyUSD usd)
    {
        double rate = 0.85; // Курс обмена USD -> EUR
        CurrencyEUR eur = new CurrencyEUR { Value = usd.Value * rate };
        return eur;
    }
    public static explicit operator CurrencyRUB(CurrencyUSD usd)
    {
        double rate = 70.0; // Курс обмена USD -> RUB
        CurrencyRUB rub = new CurrencyRUB { Value = usd.Value * rate };
        return rub;
    }
}
class CurrencyEUR : Currency
{
    public static explicit operator CurrencyUSD(CurrencyEUR eur)
    {
        double rate = 1.18; // Курс обмена EUR -> USD
        CurrencyUSD usd = new CurrencyUSD { Value = eur.Value * rate };
        return usd;
    }
    public static explicit operator CurrencyRUB(CurrencyEUR eur)
    {
        double rate = 82.0; // Курс обмена EUR -> RUB
        CurrencyRUB rub = new CurrencyRUB { Value = eur.Value * rate };
        return rub;
    }
}
class CurrencyRUB : Currency
{
    public static explicit operator CurrencyUSD(CurrencyRUB rub)
    {
        double rate = 0.014; // Курс обмена RUB -> USD
        CurrencyUSD usd = new CurrencyUSD { Value = rub.Value * rate };
        return usd;
    }

    public static explicit operator CurrencyEUR(CurrencyRUB rub)
    {
        double rate = 0.012; // Курс обмена RUB -> EUR
        CurrencyEUR eur = new CurrencyEUR { Value = rub.Value * rate };
        return eur;
    }
}

class Program
{
    static void Main()
    {
        CurrencyUSD usd = new CurrencyUSD { Value = 100 };
        CurrencyEUR eur = (CurrencyEUR)usd;
        CurrencyRUB rub = (CurrencyRUB)usd;

        Console.WriteLine($"USD: {usd.Value}, EUR: {eur.Value}, RUB: {rub.Value}");
    }
}
