using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheesyness
{
    public class HeroRpg : Character
    {
        int[] PlayerPosition = new int[2];
        
        HeroRpg(string Name, int HP, int STR, int CC, string Element, int[] PP, int CurrentLvl) : base(Name, HP, STR, CC, Element)
        {
            Element = "Neutral";
            PlayerPosition = PP;
        }



        public int[] tBuffs = new int[] { 0, 0 };
        //tBuffs indique en premier élément du couple les modifications d'attaque, le deuxième élément ceux de défense.

        public void LevelUp()
        {
            CurrentLvl++;
            STR = STR + 2;
            DEF = DEF + 2;
            HP = HP + 10;
            if (CurrentLvl % 2 == 0) Character.CC++;
        }
        
        //if ClassChoice != {Warrior, Mage, Swordmage }
        
        
        
        //TODO: EXPGained
        //TODO: CurrentLvl
        //TODO: PlayerPosition
        
    }
}
