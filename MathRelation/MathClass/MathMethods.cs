using System;

class MathMethods
{
    public void ClassMethods()
    {
        Console.WriteLine("Calling Class From the Math Method Class");
        
        // Declare and initialize variables
        double x = 3;
        double y = 5;
        double z = -0.23;
        double p = 3.133;
        double j = 7.987;
        double k = 7.987;

        // Math.Pow: Calculate x raised to power of 3 (3^3 = 27)
        double a = Math.Pow(x, 3);
        // Math.Sqrt: Calculate square root of x (√3 ≈ 1.732)
        double b = Math.Sqrt(x);
        // Math.Abs: Get absolute value of z (|-0.23| = 0.23)
        double c = Math.Abs(z);
        // Math.Round: Round k to nearest integer (7.987 → 8)
        double d = Math.Round(k);
        // Math.Ceiling: Round p up to nearest integer (3.133 → 4)
        double e = Math.Ceiling(p);
        // Math.Floor: Round j down to nearest integer (7.987 → 7)
        double f = Math.Floor(j);
        // Math.Min: Find smaller value between x and y (min(3, 5) = 3)
        double g = Math.Min(x, y);
        // Math.Max: Find larger value between x and y (max(3, 5) = 5)
        double h = Math.Max(x, y);

        // Display results
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
        Console.WriteLine(g);
        Console.WriteLine(h);
    }
}