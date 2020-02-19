using System;
using System.Collections.Generic;
using System.Text;

namespace Sunksub04Bibli.Bateau
{
    class Navire : IComparable<Navire>
    {
        //Propriété de Classe : 
        private static int IDInstNavire = 1;
        //Propriété d'Instance : 
        private int ID = 0;
        public bool FenetreDeTir;
        public int CoordonneeX { get; protected set; }
        public int CoordonneeY { get; protected set; }
        protected char Drapeau { get; set; }
        public string DrapeauToString {get; protected set; }
        public string Nom { get; protected set; }
        public bool EstDetruit { get; private set; }
        public string Etat { get; protected set; }
        //Ajout de Propriétés : 
        public int Direction { get; set; }
        public string DirectionToString { get; protected set; }
        public int Vitesse { get; private set; }
        public int VitesseToKey { get; set; }
        public string VitesseToString { get; protected set; }
        private int PorteeObus;
        private int PorteeVision;
        public string MessagePorteeObus { get; private set; }
        public string MessagePorteeVision { get; private set; }
        public bool ObjetPorteeObus{get;private set;}
        public bool ObjetPorteeVue { get; private set; }
        /// <summary>
        /// Constructeur par Défaut : Crée un navire Neutre.
        /// </summary>
        public Navire()
        {
            ID = IDInstNavire;
            IDInstNavire++;
            FenetreDeTir = false;
            CoordonneeX = 0;
            CoordonneeY = 0;
            Drapeau = 'N';
            DrapeauToString = "Neutre";
            Nom = "Navire";
            EstDetruit = false;
            Etat = "Intact";
            Direction = 5;
            DirectionToString = "Surplace";
            Vitesse = 0;
            VitesseToKey = 5;
            VitesseToString = "Nulle";
            PorteeObus = 2;
            PorteeVision = 4;
            MessagePorteeObus = "";
            MessagePorteeVision = "";
            ObjetPorteeObus = false;
            ObjetPorteeVue = false;
        }
        /// <summary>
        /// Constructeur avec param :
        /// </summary>
        /// <param name="x">Coordonnée X</param>
        /// <param name="y">Coordonnée Y</param>
        /// <param name="d">Drapeau char</param>
        /// <param name="dToString">Drapeau String</param>
        public Navire (int x, int y, char d, string dToString)
        {
            ID = IDInstNavire;
            FenetreDeTir = false;
            IDInstNavire++;
            CoordonneeX = x;
            CoordonneeY = y;
            Drapeau = d;
            DrapeauToString = dToString;
            Nom = "Navire";
            EstDetruit = false;
            Etat = "Intact";
            Direction = 5;
            //Une question d'affichage me fait rajouter des espaces après "SURPLACE[   ];
            DirectionToString = "Surplace  ";
            Vitesse = 0;
            VitesseToKey = 5;
            VitesseToString = "Nulle";
            PorteeObus = 2;
            PorteeVision = 4;
            ObjetPorteeObus = false;
            ObjetPorteeVue = false;

            
        }
        /// <summary>
        /// Donner une Direction au Navire :
        /// </summary>
        /// <param name="pDirection"></param>
        public void Avance(int pDirection)
        {
            switch (pDirection)
            {
                case 1:
                    CoordonneeX = CoordonneeX - Vitesse;
                    CoordonneeY = CoordonneeY + Vitesse;
                    break;
                case 2:
                    CoordonneeX = CoordonneeX + 0;
                    CoordonneeY = CoordonneeY = CoordonneeY + Vitesse;

                    break;
                case 3:
                    CoordonneeX = CoordonneeX + Vitesse;
                    CoordonneeY = CoordonneeY + Vitesse;
                    break;
                case 4:
                    CoordonneeX = CoordonneeX - Vitesse;
                    CoordonneeY = CoordonneeY + 0;
                    break;
                case 5:
                    CoordonneeX = CoordonneeX + 0;
                    CoordonneeY = CoordonneeY + 0;
                    break;
                case 6:
                    CoordonneeX = CoordonneeX + Vitesse;
                    CoordonneeY = CoordonneeY + 0;
                    break;
                case 7:
                    CoordonneeX = CoordonneeX - Vitesse;
                    CoordonneeY = CoordonneeY - Vitesse;
                    break;
                case 8:
                    CoordonneeX = CoordonneeX + 0;
                    CoordonneeY = CoordonneeY - Vitesse;
                    break;
                case 9:
                    CoordonneeX = CoordonneeX + Vitesse;
                    CoordonneeY = CoordonneeY - Vitesse;
                    break;
                default:
                    Console.WriteLine("Erreur dans la méthode Avance du Navire :");
                    break;
            }
        }/// <summary>
        /// Couler Ce navire :
        /// </summary>
        public void Couler()
        {
            EstDetruit = true;
            Etat = "Coulé";
        }
        public string MethodeDirectionToString(int pDirection)
        {
            string traductionDirection = "";
            switch (pDirection)
            {
                case 1:
                    traductionDirection = "Sud-Ouest";
                    break;
                case 2:
                    traductionDirection = "Sud       ";
                    break;
                case 3:
                    traductionDirection = "Sud-Est   ";
                    break;
                case 4:
                    traductionDirection = "Ouest     ";
                    break;
                case 5:
                    traductionDirection = "Surplace  ";
                    break;
                case 6:
                    traductionDirection = "Est       ";
                    break;
                case 7:
                    traductionDirection = "Nord-Ouest";
                    break;
                case 8:
                    traductionDirection = "Nord      ";
                    break;
                case 9:
                    traductionDirection = "Nord-Est  ";
                    break;
                default:
                    //Console.WriteLine("Erreur dans la méthode To String Direction XX du Navire :");
                    break;
            }
            DirectionToString = traductionDirection;
            return traductionDirection;
        }
        public string MethodeVitesseToString(int pVitesse)
        {
            string vitesseToString = "";
            switch (pVitesse)
            {
                case 0:
                    vitesseToString = "Arrêt [Avarie Moteur]       ";
                    break;
                case 1:
                    vitesseToString = "Machine arrière Forcée [4]  ";
                    break;
                case 2:
                    vitesseToString = "Machine arrière Toute [3]   ";
                    break;
                case 3:
                    vitesseToString = "Machine arrière  [2]        ";
                    break;
                case 4:
                    vitesseToString = "Machine arrière Lente [1]   ";
                    break;
                case 5:
                    vitesseToString = "Machine Stop [0]            ";
                    break;
                case 6:
                    vitesseToString = "Machine avant Lente [1]     ";
                    break;
                case 7:
                    vitesseToString = "Machine avant [2]           ";
                    break;
                case 8:
                    vitesseToString = "Machine avant Toute [3]     ";
                    break;
                case 9:
                    vitesseToString = "Machine avant Forcée [4]    ";
                    break;
                default:
                    Console.WriteLine("Erreur dans la méthode To String Vitesse du Navire :");
                    break;
            }
            VitesseToString = vitesseToString;
            return VitesseToString;
        }
        public int MethodeVitesseFromVitesseKey(int pVitesseToKey)
        {
            int pVitesse = 0;
            switch (pVitesseToKey)
            {
                case 0:
                    pVitesse = 0;
                    break;
                case 1:
                    pVitesse = 4;
                    break;
                case 2:
                    pVitesse = 3;
                    break;
                case 3:
                    pVitesse = 2;
                    break;
                case 4:
                    pVitesse = 1;
                    break;
                case 5:
                    pVitesse = 0;
                    break;
                case 6:
                    pVitesse = 1;
                    break;
                case 7:
                    pVitesse = 2;
                    break;
                case 8:
                    pVitesse = 3;
                    break;
                case 9:
                    pVitesse = 4; ;
                    break;
                default:
                    Console.WriteLine("Erreur dans la méthode To Key Vitesse du Navire :");
                    break;
            }
            Vitesse = pVitesse;
            return pVitesse;
        }
        public void DonnerDirectionEtVitesse(int pDirection, int pVitesse)
        {
            Direction = pDirection;
            DirectionToString = MethodeDirectionToString(pDirection);
            VitesseToKey = pVitesse;
            Vitesse = MethodeVitesseFromVitesseKey(VitesseToKey);
            VitesseToString = MethodeVitesseToString(VitesseToKey);
            
        }
        //Envoyer un Rapport :
        public override string ToString()
        {
            MethodeDirectionToString(Direction);
            MethodeVitesseToString(Vitesse);
            string toString = $"{Nom} avec drapeau {Drapeau}, en ({CoordonneeX} ; {CoordonneeY}) - //Etat : {Etat}// \n" +
                              $" *          Semble prendre la direction : {DirectionToString} : à la vitesse de **{VitesseToString}**";
            
            return toString;
        }
        /// <summary>
        /// Debug : Déplacer un navire à la position x;y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Teleportation(int x, int y)
        {
            CoordonneeX = x;
            CoordonneeY = y;
        }
        public void DistanceAvecNavire(Navire other)
        {
            double distanceAvecNavire = Math.Sqrt(
                                        Math.Pow((this.CoordonneeX - other.CoordonneeX), 2) +
                                        Math.Pow((this.CoordonneeY - other.CoordonneeY), 2));
            if (distanceAvecNavire <= PorteeVision && EstDetruit == false)
            {
                MessagePorteeVision = "Navire en vue, Capitaine !";
                other.FenetreDeTir = false;
                ObjetPorteeObus = false;
                ObjetPorteeVue = true;

                if (distanceAvecNavire <= PorteeObus)
                {
                    MessagePorteeObus = "Navire à portée d'Obus, Capitaine !";
                    other.FenetreDeTir = true;
                    ObjetPorteeObus = true;
                    ObjetPorteeVue = true;
                }
            }
            else
            {
                MessagePorteeVision = "Vigie sur le Pont : R.A.S.";
                other.FenetreDeTir = false;
                ObjetPorteeObus = false;
                ObjetPorteeVue = false;
            }
        }

        //Comparer les navires :
        public override bool Equals(object obj)
        {
            Navire other = obj as Navire;
            return (other != null) && this.ID.Equals(other.ID);
        }
        public int CompareTo(Navire other)
        {
            if (other != null)
            {
                return this.ID.CompareTo(other.ID);
            }
            else
                return 1;
        }
        public virtual void PrendreObusDansLaFace()
        {
            if (Etat == "Intact")
            {
                Couler();
            }
        }
    }
}
