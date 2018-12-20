using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheesyness
{
    public class Cell
    {
        public int X;
        public int Y;
        public Character.Monster m;
        //public Equipment Item;
        public Character.HeroRPG Hero;

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
            Hero = null;
            /*Item = new Potion("Soin", "Potion de soin", 1, 2, Potion.PotionType.Heal);*/
            //TODO : Chances de spawn un Monstre et une popoSoin.Niv1. 40% et 20% respectivement
        }
        /*
        public Cell[,] StartingPosition;
        public Cell[,] AdvancementCell;
         */
    }
}
