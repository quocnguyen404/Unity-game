using Csharp;

class Program
{
    static void Main()
    {
        List<Item> tempItems = new List<Item>();

        //generate 10 random items
        for (int i = 0; i < 10; i++)
        {
            tempItems.Add(GameUtilities.GetRandomItem());
        }

        //show all random items
        Console.WriteLine("RANDOM ITEMS LIST");
        GameUtilities.ShowInfor(tempItems);
        Console.WriteLine("");

        //Create inventory
        Inventory inventory = new Inventory();

        //Store Item
        foreach (Item item in tempItems)
        {
            if (GameUtilities.CanStore(item, inventory.Items))
                inventory.StoreItem(item);
            else
                inventory.AddGold(item.Price);
        }

        //Sell Epic and Rare weapons in inventory
        foreach (string key in inventory.Items.Keys)
        {
            inventory.SellItem(inventory.Items[key], GameUtilities.IsEpicRare(inventory.Items[key]));
        }

        //Sort
        inventory.Sort();

        //Show all items in inventory
        Console.WriteLine();
        Console.WriteLine("REMAIN ITEMS");
        inventory.ShowAllItem();
        Console.WriteLine();
        Console.WriteLine("Gold: " + inventory.Gold);
    }
}