using System;
using System.Reflection.Metadata;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {

        const string TLD = ".com"; // top level domain

        Console.Write("Please Input Your Name: ");
        String name = Console.ReadLine() ?? "";
        Console.WriteLine("Hello " + name);

        Console.Write("Please Input Your Surname: ");
        String surname = Console.ReadLine() ?? "";
        Console.WriteLine("Your Surname is " + surname);

        Console.WriteLine("Combine of two Input variables");
        Console.WriteLine("Your Fullname is " + name + " " + surname);

        Console.Write("Please input what kind of email you will be used: ");
        String email = Console.ReadLine() ?? "";
        string emailDisplay = "Your Email is " + email + TLD;
        Console.WriteLine(emailDisplay);

        Console.WriteLine("================================================");
        Console.WriteLine("Created Email: " + surname + name + "@" + email + TLD);
        
    }
}