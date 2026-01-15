using System;

class Program
{
    static void Main()
    {
        String fullname = "Bro Code";
        String phoneNumber = "123-456-789";
        String userName = "Darryll Pogi";

        fullname = fullname.ToUpper();
        Console.WriteLine(fullname);
        fullname = fullname.ToLower();
        Console.WriteLine(fullname);
        
        phoneNumber = phoneNumber.Replace("-","");
        Console.WriteLine(phoneNumber);

        String userName_new = userName.Insert(0, "@");
        Console.WriteLine(userName_new);

        String firstname = fullname.Substring(0,4); // bro
        Console.WriteLine(firstname);

        String lastname = fullname.Substring(4,4); // code
        Console.WriteLine(lastname);

    }
}