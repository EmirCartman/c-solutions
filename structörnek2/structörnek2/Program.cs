using System;

public struct ComplexNumber
{
   
    public double Real { get; set; }
    public double Imaginary { get; set; }

    
    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

  
    public ComplexNumber Add(ComplexNumber other)
    {
        return new ComplexNumber(this.Real + other.Real, this.Imaginary + other.Imaginary);
    }

  
    public ComplexNumber Subtract(ComplexNumber other)
    {
        return new ComplexNumber(this.Real - other.Real, this.Imaginary - other.Imaginary);
    }

    
    public override string ToString()
    {
        string sign = Imaginary >= 0 ? "+" : "-";
        return $"{Real} {sign} {Math.Abs(Imaginary)}i";
    }
}

class Program
{
    static void Main()
    {
        
        ComplexNumber num1 = new ComplexNumber(3, 4);
        ComplexNumber num2 = new ComplexNumber(1, -2);

        Console.WriteLine($"Num1: {num1}");
        Console.WriteLine($"Num2: {num2}");

        ComplexNumber sum = num1.Add(num2);
        Console.WriteLine($"\nToplama Sonucu: {sum}");
        
        ComplexNumber difference = num1.Subtract(num2);
        Console.WriteLine($"Çıkarma Sonucu: {difference}");
    }
}
