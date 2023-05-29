using Csharp;

public class ItemComparer : IComparer<Item>
{
    public int Compare(Item item1, Item item2)
    {
        int returnValue = item1.Type.CompareTo(item2.Type);

        if (returnValue == 0)
        {
            Weapon? weapon1 = item1 as Weapon;
            Weapon? weapon2 = item2 as Weapon;

            if (weapon1 != null)
            {
                int CQuality = weapon1.Quality.CompareTo(weapon2.Quality);

                if (CQuality == 0)
                    CQuality = weapon1.Level.CompareTo(weapon2.Level);
                
                returnValue = CQuality;
            }
            else
            {
                Cloth? cloth1 = item1 as Cloth;
                Cloth? cloth2 = item2 as Cloth;

                if (cloth1 != null)
                {
                    int CRarity = cloth1.Rarity.CompareTo(cloth2?.Rarity);

                    if (CRarity == 0)
                        CRarity = cloth1.Star.CompareTo(cloth2?.Star);

                    returnValue = CRarity;
                }
            }
        }

        return returnValue;
    }
}

