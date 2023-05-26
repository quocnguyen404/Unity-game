using Csharp;
using System;

class Program
{
    static void Main()
    {
        Item[] tempItems = new Item[10];

        //generate 10 random items
        for (int i = 0; i < tempItems.Length; i++)
        {
            tempItems[i] = GameUtilities.GetRandomItem();
            System.Threading.Thread.Sleep(100);
        }

        //show all random items
        Console.WriteLine("RANDOM ITEMS LIST");
        GameUtilities.ShowInfor(tempItems);
        Console.WriteLine("-------------------");

        Inventory inventory = new Inventory();

        foreach (Item item in tempItems)
        {
            if (GameUtilities.CanStore(item))
                inventory.StoreItem(item);
            else
                inventory.AddGold(item.Price);
        }

        Console.WriteLine("--------------");
        Console.WriteLine("REMAIN ITEMS");
        inventory.ShowAllItem();
    }
}