using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class Cloth : Item
    {
        public enum _Rarity
        {
            C = 1,
            B,
            A,
            S,
        }

        protected int star;
        protected _Rarity rarity;

        public int Star { get => star; }
        public _Rarity Rarity { get => rarity; }

        public override float Price => base.Price * Star * (float)Rarity;

        public Cloth()
        {
            star = GameUtilities.GetRandom(1, 5);
            rarity = (_Rarity)GameUtilities.GetRandom(1, 4);
        }

        public override void ShowInfor()
        {
            base.ShowInfor();
            Console.WriteLine("Star: " + Star);
            Console.WriteLine("Rarity: " + Rarity);
        }

    }
}
