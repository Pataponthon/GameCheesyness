using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheesyness
{
    class Equipment
    {
        public string Name;
        public string Description;
        public float Value;
        public float Weight;

        public Equipement(string name, string descript, float v, float w)
        {
            Name = name;
            Description = descript;
            Value = v;
            Weight = w;
        }

        public void Print()
        {
            Console.WriteLine(Name + " : " + Description);
        }

        public virtual void PickUp()
        {
            Console.WriteLine("Vous ramassez :" + Name);
        }
        public virtual void Use()
        {
            Console.WriteLine("Vous utilisez :" + Name);
        }
    }
}
