using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheesyness.Map
{
    public class MapGeneration : Map
    {
        // int[] u = new int[2];
        int[] StartingPosition = new int[2];
        int[] AdvancementCell = new int[2];
        int[] InaccessibleCell = new int[2];
        //Map Map1;
        public override  Map Map1()
        {
            /* utter garbage
            int[,] StartingCell = new int[,];
            int[,] InaccessibleCell = new int[][,];
            int[,] AdvancementCell = new int[,];
            */

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
