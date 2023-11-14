using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction simple = new Fraction();

        Fraction wholeNumber = new Fraction(6);

        Fraction complex = new Fraction(6,7);

        wholeNumber.SetTop(3);

        Console.WriteLine(wholeNumber.GetTop());

        complex.SetBottom(5);

        Console.WriteLine(complex.GetBottom());
    }
}