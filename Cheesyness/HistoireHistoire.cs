using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheesyness
{
    public class HistoireHistoire
    {
        public void Beginning();
        {
            Console.WriteLine("Vous trouvez un parmachin antique dont vous êtes le destinataire.");
            Console.WriteLine("Il est écrit : Poisson deux points Poisson. Cela ne vous dit rien qui vaille.");
            Console.WriteLine("Vous vous rendez donc en Walachia pour savoir ce qu'il se trame.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press Aniki to continue.");
            Console.ReadLine();
            Console.ResetColor();
            Cheesyness.Map.MapGeneration.Map1();
            Movement();
        }

        public void Interlude1();
        {
            Console.WriteLine("Voix : QUELLE EST CETTE VERMINE QUI ENTRE DANS MON DOMAINE ?!");
            Console.WriteLine("Voix : Je suis le grand et tout puissant CARAMELITOS !!");
            Console.WriteLine("Caramelitos : Ohhhhh je vois que tu es l'avatar de fromage");
            Console.WriteLine("Caramelitos : Pour vaincre le Comté Shuzard, avance dans le Prieuré Laitier, et pourfends tes ennemis, ÔÔÔ Avatar.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press Aniki to continue.");
            Console.ReadLine();
            Console.ResetColor();
            Cheesyness.Map.MapGeneration.Map2();
            Movement();
        }
        
        //public void BASTONBASTON();
        {
        }
    }
}
