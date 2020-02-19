using Sunksub04Bibli.Moteur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunkTestNum2
{
    class Program
    {
        /// <summary>
        /// Jeu de Bataille Navale dans l'esprit SilentHunter Demake:
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Va chercher La fonction boucle du Jeu : Dans Moteur (FrameworkMaison)
            Loop.InitStart();
            //Sortie du Programme :
            Console.ReadKey(true);
        }
    }
}
