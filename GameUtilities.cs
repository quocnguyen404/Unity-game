using Csharp;

public static class GameUtilities
{
    public static void ShowInfor(List<Item> items)
    {
        foreach (Item item in items) 
        {
            item.ShowInfor();
        }
    }

    public static int GetRandom(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }

    public static Item GetRandomItem()
    {
        int ranNum = GetRandom(0, 100);

        if (ranNum % 2 == 0)
            return new Weapon();
        else
            return new Cloth();
    }

    public static bool CanStore(Item item, Dictionary<string, Item> Items)
    {
        bool CanStore = true;

        if (Items.ContainsKey(item.Name))
        {
            CanStore = false;
            if (item.Price > Items[item.Name].Price)
                CanStore = true;
        }

        return CanStore;
    }

    public static bool IsEpicRare(Item item)
    {
        bool condition = false;
        Weapon weapon = item as Weapon;
        if (weapon == null)
            return condition;
        else
        {
            if ((int)weapon.Quality == 2 || (int)weapon.Quality == 3)
                condition = true;
        }

        return condition;
    }
    //public static void SellEpicAndRare(Inventory inventory)
    //{
    //    Dictionary<string, Item> Items = inventory.Items;

    //    List<Item> weapons = new List<Item>();

    //    foreach (string key in Items.Keys)
    //    {
    //        if (Items[key] is Weapon)
    //        {
    //            weapons.Add(Items[key]);
    //        }
    //    }

    //    foreach (Weapon weapon in weapons)
    //    {
    //        if ((int)weapon.Quality == 2 || (int)weapon.Quality == 3)
    //            inventory.SellItem(weapon);
    //    }
    //}

    //public static Item[] RemoveItem(Item[] arr, int index)
    //{
    //    Item[] newArr = new Item[arr.Length - 1];
        
    //    for (int i = 0; i < arr.Length - 1; i++)
    //    {
    //        if (i < index)
    //            newArr[i] = arr[i];
    //        else
    //            newArr[i] = arr[i + 1];
    //    }

    //    return newArr;
    //}
}