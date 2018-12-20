using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheesyness.Combat
{
    class Battle
    {
        
        
            //TODO : Déclarer les deux variables.
            Character.HeroRpg.LevelUp();
        if (Character.HeroRpg.EXP_GAINED >= EXP_THRESHOLD)
        {	
            EXP_EXCESS = EXP_Threshold - EXP_GAINED;
            Character.HeroRpg.LevelUp();
            EXP_GAINED = EXP_EXCESS;
            EXP_EXCESS = 0;
        }
    }
}
