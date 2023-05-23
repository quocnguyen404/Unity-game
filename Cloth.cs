using System;

internal class Cloth : Item
{
    public enum RATE
    {
        Common = 1,
        Uncommon,
        Rare,
        Mystery,
    }
    
    
    private RATE rate;
    private int star;

    public RATE Rate { get => rate; }
    public int Star { get => star; }


    public Cloth()
    {
        type = _Type.Cloth;

        Random random = new Random();
        int RatioRate = random.Next(1, 100);

        if (RatioRate <= 65) rate = RATE.Common;
        if (RatioRate > 65 && RatioRate <= 85) rate = RATE.Uncommon;
        if (RatioRate > 85 && RatioRate <= 95) rate = RATE.Rare;
        if (RatioRate > 95) rate = RATE.Mystery;

        int RatioStar = random.Next(1, 5);
        star = RatioStar;

        price = price * star * (float)rate;
    }

    public override void ShowInfor()
    {
        base.ShowInfor();
        Console.WriteLine("Rate: " + Rate);
        Console.WriteLine("Star: " + Star);
    }
}
