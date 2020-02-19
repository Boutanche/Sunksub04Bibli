using System;
using System.Collections.Generic;
using System.Text;

namespace Sunksub04Bibli.Bateau
{
    class NavireJoueur : NavireGuerre
    {
        public NavireJoueur()
            : base()
        {
            CoordonneeX = 50;
            CoordonneeY = 50;
            Drapeau = 'R';
            DrapeauToString = "Rouge";
            Nom = Nom + " de Formation ";
        }
    }
}
