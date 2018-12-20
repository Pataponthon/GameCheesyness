using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheesyness
{
    class Cell
    {
        public int X;
        public int Y;
        public Monster m;
        public Equipment Item;
        public HeroRPG Hero;
        public Advancement Advance;

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
            Hero = null;
            Advance = null;
           /*Item = new Potion("Soin", "Potion de soin", 1, 2, Potion.PotionType.Heal);*/
           
        }

    }
}
