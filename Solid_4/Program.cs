using System;

interface IItem
{
}

interface IApplier : IItem
{
    void ApplyDiscount(String discount);
    void ApplyPromocode(String promocode);
}

interface ISetter : IItem
{
    void SetColor(byte color);
    void SetSize(byte size);

    void SetPrice(double price);
}

class Book : IApplier
{
    public void ApplyDiscount(string discount)
    {
        // do sth ...
    }

    public void ApplyPromocode(string promocode)
    {
        // do sth ...
    }
}

class OuterWear : ISetter
{
    public void SetColor(byte color)
    {
        // do sth ...
    }

    public void SetPrice(double price)
    {
        // do sth ...
    }

    public void SetSize(byte size)
    {
        // do sth ...
    }
}
class Program
{
    static void Main(string[] args)
    {
       
        Console.ReadKey();
    }
}