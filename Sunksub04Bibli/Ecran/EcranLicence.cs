using Sunksub04Bibli.Moteur;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sunksub04Bibli.Ecran
{
    class EcranLicence
    {
        public static void Licence()
        {
            Console.SetWindowSize(80, 21);
            Draw.DrawLicenceScreen();
        }
    }
}
