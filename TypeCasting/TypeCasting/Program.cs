using System;

class Program
{
    static void Main()
    {
            // type Casting = Converting a value to a different data type
            //                Useful when we accept user input (string))
            //                Different data types can do different things

        // task to convert each variables to different datatype using typecasting method
        // task : convert double value to integer 
        double a = 3.14;
        int b = Convert.ToInt32(a);
        Console.WriteLine(a);
        Console.WriteLine(a.GetType());

        // task : convert integer value to double using typecasting
        int c = 365;
        double d = Convert.ToDouble(c);
        Console.WriteLine(d);
        Console.WriteLine(d.GetType());

        // task : convert string to boolean 
        string e = "true";
        Boolean f = Convert.ToBoolean(e);
        Console.WriteLine(f);
        Console.WriteLine(f.GetType());
    }
}