using Sunksub04Bibli.Moteur;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sunksub04Bibli.Ecran
{
    class EcranTitre
    {
        public static void TitreScreen()
        {
            Console.SetWindowSize(160, 50);
            Draw.DrawTitleScreen();
        }
    }
}
