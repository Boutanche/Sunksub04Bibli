using Sunksub04Bibli.Moteur;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sunksub04Bibli.Ecran
{
    class EcranGame
    {
        public static void StartGame()
        {
            Console.SetWindowSize(160, 50);
            Draw.DrawScreenGame();
        }
    }
}
