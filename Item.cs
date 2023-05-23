using System;

internal class Item
{
    public enum _Type
    {
        Weapon,
        Cloth,
    }

    protected string name = "";
    protected float price;
    protected _Type type;

    public string Name { get => name; set => name = value; }
    public float Price { get => price; }
    public _Type Type { get => type; }

    public Item()
    {
        Random random = new Random();
        price = random.Next(1, 5);
    }

    public virtual void ShowInfor()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Type: " + Type);
    }

    public Item Store() => this;
    public float Sell() => Price;

    public virtual void Enter()
    {
        Console.WriteLine(Type);
        Console.Write("Enter item name: ");
        Name = Console.ReadLine();
    }
}
