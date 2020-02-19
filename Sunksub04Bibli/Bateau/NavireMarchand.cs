using System;
using System.Collections.Generic;
using System.Text;

namespace Sunksub04Bibli.Bateau
{
    class NavireMarchand : Navire
    {
        public NavireMarchand()
            : base()
        {
            Nom = Nom + " Marchand";
        }
        public NavireMarchand(int x, int y, char d, string dToString)
            : base(x, y, d, dToString)
        {
            CoordonneeX = x;
            CoordonneeY = y;
            Drapeau = d;
            DrapeauToString = dToString;
            Nom = Nom + " Marchand";
        }
    }
}
