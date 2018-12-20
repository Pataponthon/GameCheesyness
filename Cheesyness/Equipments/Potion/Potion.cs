using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheesyness.Equipment
{
    class Potion : Equipment
    {
        public enum PotionType { Heal, ATK, DEF}
        public PotionType Type
        public Potion(string name, string descript, float v, float w)
            : base(name, descript, v, w)
        {
            Type = t;
        }
        //TODO : Faire la description des items (brève)
        public override void PickUp()
        {
            base.PickUp();
            Console.WriteLine("Vous avez une nouvelle potion");
        }

        public override void Use()
        {
            base.Use();
            Console.WriteLine("Vous avez utilisé une potion");
        }
    }
}
