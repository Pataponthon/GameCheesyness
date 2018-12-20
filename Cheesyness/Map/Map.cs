using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheesyness
{
    class Map
    {
        /* exemple du cours
        public int NbCases;
        public string Nom;
        public Cell[,] Plateau;
        public int MaxPlateau;

        public Map(int largeur, int longueur)
        {
            Largeur = largeur;
            Longueur = longueur;
            Plateau = new Cell[largeur, longueur];
            for (int i = 0; i < Largeur; i++)
            {
                for (int j = 0; i < Longueur; j++)
                {
                    Plateau[i, j] = new Case();

                }
            }
        }
        */
        /*public string Name;*/
        public Cell[,] Plateau;

        public Map()
        {
            Plateau = new Cell[5, 5];
            for (int i=0; i<5; i++)
            {
                for (int j=0;j<5, j++)
                {
                    Plateau[i, j] = new Cell();
                }
            }
        }

    }
}
