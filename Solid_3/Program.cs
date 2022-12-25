using System;

//Було порушено принцип заміщення Лісков

abstract class Shape
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public abstract int GetArea();
}

class Rectangle : Shape
{
    public override int Width { get; set; }
    public override int Height { get; set; }
    public override int GetArea()
    {
        return Width * Height;
    }
}
class Square : Rectangle
{
    public int Side { get; set; }
    public int GetSquareArea()
    {
        return Side * Side;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Square();
        rect.Width = 5;
        rect.Height = 10;

        Console.WriteLine(rect.GetArea());
        Console.ReadKey();
    }
}