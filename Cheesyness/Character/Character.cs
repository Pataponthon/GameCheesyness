using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheesyness
{
    public class Character
    {
        public string name;
        protected int hp;
        protected int str;
        
        //CC = Counter-Counter, le nombre limite de contres consécutifs possibles.
        protected int cc;
        string[] tElement = new string[] { "Neutral", "Fire", "Water", "Wind", "Cheese" };
        
        public Character(string Name, int HP, int STR, int CC, string[] Element)
        {
            name = Name;
            hp = HP;
            str = STR;
            cc = CC;
            tElement = Element;
        }

        public virtual Skills();


        


    }
}
