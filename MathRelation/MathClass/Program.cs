using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("This is The Main Class");
        //This is the Class for Arithmetic Operators
        ArithmeticOperators ariOpera = new ArithmeticOperators();
        ariOpera.ClassOperators();
        Console.WriteLine("=================================================");
        //This is the Class for Math Methods
        MathMethods methods = new MathMethods();
        methods.ClassMethods();
    }
}