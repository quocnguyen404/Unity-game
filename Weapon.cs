using System;

internal class Weapon : Item
{
    public enum QUALITY
    {
        C = 1,
        B,
        A,
        S,
    }

    private QUALITY quality;
    private int level;

    public QUALITY Quality { get => quality; }
    public int Level { get => level;}

    public Weapon()
    {
        type = _Type.Weapon;

        Random random = new Random();
        int RatioQuality = random.Next(1, 100);

        if (RatioQuality <= 65) quality = QUALITY.C;
        if (RatioQuality > 65 && RatioQuality <= 85) quality = QUALITY.B;
        if (RatioQuality > 85 && RatioQuality <= 95) quality = QUALITY.A;
        if (RatioQuality > 95) quality = QUALITY.S;

        int RandomLevel = random.Next(1, 30);
        level = RandomLevel;
        price = price * level * (float)quality;
    }

    public override void ShowInfor()
    {
        base.ShowInfor();
        Console.WriteLine("Quality: " + quality);
        Console.WriteLine("Level: " + level);
    }
}
