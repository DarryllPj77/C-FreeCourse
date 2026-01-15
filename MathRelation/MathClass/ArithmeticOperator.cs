using System;

class ArithmeticOperators
{
    public void ClassOperators()
    {
        Console.WriteLine("Calling Class From the Arithmetic Operator Class");
        // int friends, money, pet; //Declaration + initialization 
        // friends = money = pet = 10;

        //Chained assignment
        // Declare and initialize variables
        int friends = 10, money = 10;
        double pet = 10;
        
        // Add to friends: 10 + 1 + 5 = 16
        friends = friends + 1 + 5;

        // Subtract 5 from money: 10 - 5 = 5
        money -= 5;
        // Increment money by 1: 5 + 1 = 6
        money ++;

        // Multiply pet by 2.323: 10 * 2.323 = 23.23
        pet = pet * 2.323;
        // Multiply pet by 0: 23.23 * 0 = 0
        pet *= 0;
        // Add 10 to pet: 0 + 10 = 10
        pet = pet + 10;
        // Modulo pet by 4: 10 % 4 = 2
        pet = pet % 4;

        // Display results
        Console.WriteLine(friends);
        Console.WriteLine(money);
        Console.WriteLine(pet);
    }
}