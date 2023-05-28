using Csharp;

public class Item : IComparable<Item>
{
    public enum _Type
    {
        Cloth = 1,
        Weapon,
    }

    protected int id;
    protected string name = "";
    protected float price;
    protected _Type type;

    public int itemID { get => id; }
    public string Name { get => name; }
    public virtual float Price { get => price; }
    public _Type Type { get => type; }

    public int CompareTo(Item other)
    {
        if (other == null) return -1;

        if (this.Type > other.Type)
            return -1;
        else if (this.Type < other.Type)
            return 1;
        else
            return 0;
    }

    public Item()
    {
        id = GetHashCode();
        name = GetType().Name + " " + "0" + " " + GameUtilities.GetRandom(0, 10);
        price = GameUtilities.GetRandom(5, 10);
    }

    public virtual void ShowInfor()
    {
        Console.WriteLine("-------------------");
        Console.WriteLine("Item ID: " + itemID);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Price: " + Price);
    }

}
