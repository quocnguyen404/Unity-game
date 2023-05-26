using System;

public abstract class Item
{
    protected int id;
    protected string name = "";
    protected float price = GameUtilities.GetRandom(10, 15);

    public int itemID { get => id; }
    public string Name { get => name; }
    public virtual float Price { get => price; }

    public Item()
    {
        id = GetHashCode();
        name = GetType().Name + " " + "0" + " " + GameUtilities.GetRandom(0, 10);
    }

    public virtual void ShowInfor()
    {
        Console.WriteLine("-------------------");
        Console.WriteLine("Item ID: " + itemID);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Price: " + Price);
    }

}
