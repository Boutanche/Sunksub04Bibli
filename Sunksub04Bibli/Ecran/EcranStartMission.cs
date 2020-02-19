using Sunksub04Bibli.Moteur;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sunksub04Bibli.Ecran
{
    class EcranStartMission
    {
        public static void Start()
        {
            Console.SetWindowSize(160, 50);
            Draw.DrawStartMission();
        }
    }
}
