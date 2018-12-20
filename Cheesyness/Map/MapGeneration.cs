using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheesyness.Map
{
    public class MapGeneration : Map
    {
        int[] StartingPosition = new int[2];
        int[] AdvancementCell = new int[2];
        int[] InaccessibleCell = new int[2];

        public override  Map Map1()
        { 

            StartingPosition = { 0, 1};
            AdvancementCell = { 5, 3};
            //InaccessibleCells = { { 0, 0} { 0, 1} { 0, 5} { 1, 5} };
            InaccessibleCells.Add(InaccessibleCell);
            

            if (Character.HeroRpg.PlayerPosition == AdvancementCell) { Cheesyness.HistoireHistoire.Interlude1(); }
        }
        /*
        void public Map Map2()
        {

        }
        */
        }
    }
