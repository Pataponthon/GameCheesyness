using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheesyness.Map
{
    class MapGeneration
    {
        void public Map Map1()
        {
            int[,] StartingCell = new int[,];
            int[,] InaccessibleCell = new int[][,];
            int[,] AdvancementCell = new int[,];
            InaccessibleCell = { { 0, 0} { 0, 1} { 0, 5} { 1, 5} };

            AdvancementCell = { 5, 3};
            if (Character.HeroRpg.PlayerPosition == AdvancementCell) { Interlude1(); }
        }
        /*
        void public Map Map2()
        {

        }
        */
    }
}
