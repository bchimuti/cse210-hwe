using System;
using System.Xml.Schema;

class Program
{
    static void Main()
    {
        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(5);
        Fraction frac3 = new Fraction(3, 4);
        Fraction frac4 = new Fraction(1, 3); 

        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());

        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());

        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());

        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.GetDecimalValue()):

        Fraction frac5 = new Fraction();
        frac5.SetTop(7);
        frac5.SetBottom(2);
        Console.WriteLine(frac5.GetFractionString());
        Console.WriteLine(frac5.GetDecimalValue());
    }
}