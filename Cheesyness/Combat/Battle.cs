using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheesyness.Combat
{
    class Battle
    {
        
        Use();
        if (ExpGained >= ExpThreshold)
            //TODO : Déclarer les deux variables.
            Character.HeroRpg.LevelUp();
        EXP_GAINED = EXP_GAINED //CaraPlayer + MonsterEXP //CaraMob;
        if (Character.HeroRpg.EXP_GAINED >= EXP_THRESHOLD)
        {	
            EXP_EXCESS = EXP_Threshold - EXP_GAINED;
            LvlUp();
            EXP_GAINED = EXP_EXCESS;
            EXP_EXCESS = 0;
        }
    }
}
