using System;
using System.Collections.Generic;
using System.Text;

namespace Sunksub04Bibli.Bateau
{
    class NavireGuerre : Navire
    {
        private bool EstEndommage;
        public NavireGuerre()
            : base()
        {
            Nom = Nom + " de Guerre";
        }
        public NavireGuerre(int x, int y, char d, string dToString)
            : base(x, y, d, dToString)
        {
            CoordonneeX = x;
            CoordonneeY = y;
            Drapeau = d;
            DrapeauToString = dToString;
            Nom = Nom + " de Guerre";
            EstEndommage = false;
        }
        public void Endommager()
        {
            EstEndommage = true;
            Etat = "Endommagé";        
        }
        public override void PrendreObusDansLaFace()
        {
            if (Etat == "Intact")
            {
                Endommager();
            }
            else if (Etat == "Endommagé")
            {
                Couler();
            }
        }
    }
}
