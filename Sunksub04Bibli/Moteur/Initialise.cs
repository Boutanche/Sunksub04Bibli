using Sunksub04Bibli.Ecran;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sunksub04Bibli.Moteur
{
    class Initialise
    {
        public static void Launch()
        {

            EcranLicence.Licence();
            //EcranTitre.TitreScreen();
            //EcranStartMission.Start();
            EcranGame.StartGame();
        }
    }
}
