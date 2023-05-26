using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class Weapon : Item
    {
        public enum _Quality
        {
            Uncommon = 1,
            Common,
            Rare,
            Lengedary,
        }

        protected int level;
        protected _Quality quality;

        public int Level { get => level; }
        public _Quality Quality { get => quality; }

        public override float Price => base.Price * Level * (float)Quality;

        public Weapon()
        {
            quality = (_Quality)GameUtilities.GetRandom(1, 4);
            level = GameUtilities.GetRandom(1, 5);
        }

        public override void ShowInfor()
        {
            base.ShowInfor();
            Console.WriteLine("Quality: " + Quality);
            Console.WriteLine("Level: " + Level);
        }

    }
}
