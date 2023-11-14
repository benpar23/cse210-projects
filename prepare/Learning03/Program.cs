using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction simple = new Fraction();

        Fraction wholeNumber = new Fraction(5);

        Fraction complex = new Fraction(3,4);

        Fraction complexTwo = new Fraction(1,3);

        Console.WriteLine(simple.GetFractionString());
        Console.WriteLine(simple.GetDecimalValue());

        Console.WriteLine(wholeNumber.GetFractionString());
        Console.WriteLine(wholeNumber.GetDecimalValue());

        Console.WriteLine(complex.GetFractionString());
        Console.WriteLine(complex.GetDecimalValue());

        Console.WriteLine(complexTwo.GetFractionString());
        Console.WriteLine(complexTwo.GetDecimalValue());

        
    }
}