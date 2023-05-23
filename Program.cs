using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        Item[] items = new Item[10];
        Item[] chest = new Item[32];

        //generate items
        for (int i = 0; i < 10; i++)
        {
            int ranType = random.Next(0, 1);
            if (ranType == 0) 
            { 
                Item item = new Weapon();
                item.Enter();
                items[i] = item;
            }
            if (ranType == 1) 
            {  
                Item item = new Cloth(); 
                item.Enter();
                items[i] = item;
            }
        }

        //store chest
        float SellPrice = 0;
        for (int i = 0;i < 10;i++)
        {
            if (items[i].Price > 10) chest[i] = items[i].Store();
            if (items[i].Price < 10) SellPrice += items[i].Sell();
        }

        //sell all
        float SellAll = 0;
        foreach (Item item in chest)
        {
            SellAll += item.Sell();
        }
    }
}