using System;

class Program
{
    static void Main()
    {
        // Conditional Operator = used in conditional assignment if a condition is true or false
        // (condition) ? x : y

        double temperature = 20;
        String message;

        // ->No need anymore since we are using Conditional Operator
        // if (temperature >= 15)
        // {
        //     message = "It's warm Outside!";
        // }
        // else
        // {
        //     message = "It's cold Outside!";
        // }
        // Console.WriteLine(message);
        
        message = (temperature >= 15) ? "It's warm Outside!" : "It's cold Outside!";
        Console.WriteLine(message);
    }
}