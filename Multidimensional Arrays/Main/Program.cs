using System;


class Program
{
    static void Main()
    {
         String[] Foods = {"Chicken", "Hotdogs", "Cake"};
         String[] Drinks = {"Coke", "lemonade", "Sprint"};
         String[] CookStatus = {"Properly Cooked", "Over Cooked", "Not Cooked"};

                               //Column0    Column1    Column2
        String[,] Restaurant = {{"Chicken", "Hotdogs", "Cake"}, // Row 0
                               {"Coke", "lemonade", "Sprite"}, // Row 1
                               {"Properly Cooked", "Over Cooked", "Not Cooked"}}; // Row 2

        Console.WriteLine(Restaurant[1,2]);   
        Console.WriteLine(Restaurant[2,2]);
        Console.WriteLine(Restaurant[2,0]);  

        Console.WriteLine("===========");
        Console.WriteLine("=  Foods  =");
        Console.WriteLine("===========");
        foreach(String foods in Foods)
        {
            Console.WriteLine(foods);
        }
        Console.WriteLine("============");
        Console.WriteLine("=  Drinks  =");
        Console.WriteLine("============");
        foreach(String drinks in Drinks)
        {
            Console.WriteLine(drinks);
        }
        Console.WriteLine("================");
        Console.WriteLine("=  CookStatus  =");
        Console.WriteLine("================");
        foreach(String CookStatuses in CookStatus)
        {
            Console.WriteLine(CookStatuses);
        }     

        Console.WriteLine("================");
        Console.WriteLine("=  Restaurant  =");
        Console.WriteLine("================");
        for(int i = 0; i < Restaurant.GetLength(0); i++)
        {
            for(int j = 0; j < Restaurant.GetLength(1); j++)
            {
                Console.WriteLine(Restaurant[i,j] + " ");
            }
            Console.WriteLine();
        }               
    }

}    