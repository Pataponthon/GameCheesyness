using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheesyness
{
    class Menu
    {
        public Menu()
        {
            PrintMenu();
            int choix = AskChoice(0, 3);
            switch (choix)
            {
                case 0;
                    {
                        StartGame();
                        break;
        /*            }
                case 1;
                    {
                        Load();
                        break;
                    }
                case 2;
                    {
                        Apropos();
                        break;
                    }
                case 3;
                    {
                        Quit();
                        break;
                    }*/
            }
        }

        public void PrintMenu()
        {
                //TODO Faire l'affihage du Menu
                Console.WriteLine("Moisissez votre destinée");
                Console.WriteLine("0 - Start Game");
        }

        public int AskChoice(int min, int max)
        {
            int result = int.Parse(Console.ReadLine());
            while (result > max || result < min)
            {
                result = int.Parse(Console.ReadLine());
            }
            return result;
        }

        public void Game()
        {

        }

        public void Load()
        {

        }

        public void Apropos()
        {

        }

        public void Quit()
        {

        }
    }
}
