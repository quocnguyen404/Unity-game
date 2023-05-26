using Csharp;
using System;

public static class GameUtilities
{
    public static void ShowInfor(Item[] items)
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

    public static bool CanStore(Item item)
    {
        if (item is Weapon || item.Price > 10)
            return true;
        else
            return false;
    }

    public static Item[] RemoveItem(Item[] arr, int index)
    {
        Item[] newArr = new Item[arr.Length - 1];
        
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (i < index)
                newArr[i] = arr[i];
            else
                newArr[i] = arr[i + 1];
        }

        return newArr;
    }


}