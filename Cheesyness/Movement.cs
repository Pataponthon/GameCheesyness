using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheesyness
{
    public class Movement
    {
        //TODO : créer une variable supplémentaire sur laquelle revenir lors d'un passage
        //sur une case infranchissable
        public int DirectionsChoice(int min, int max)
        {
            int result = int.Parse(Console.ReadLine());
            while (result > max || result < min)
            {
                result = int.Parse(Console.ReadLine());
            }
            return result;
        }

        int choice = DirectionsChoice(0, 3);
        switch(choice)
        {
            case 0:
                Character.HeroRpg.PlayerPosition.x--;
                break;  
            case 1:
                Character.HeroRpg.PlayerPosition.y++;
                break;
            case 2:
                Character.HeroRpg.PlayerPosition.x++;
                break;
            case 3:
                Character.HeroRpg.PlayerPosition.y--;
                break;
        }
        
    
        //TODO: Condition Si vous vous déplacez dans une cellule invisible
        
        Console.WriteLine("Vous vous heurtez comme un tataki contre un mur..");
        //TODO: Condition Si vous vous déplacez hors de la zone
        Console.WriteLine("Une force invisible vous repousse...");

    }
}
