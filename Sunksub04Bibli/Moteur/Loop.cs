using Sunksub04Bibli.Bateau;
using Sunksub04Bibli.Ecran;
using Sunksub04Bibli.Outil;
using Sunksub04Bibli.Publication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Sunksub04Bibli.Moteur
{
    public class Loop
    {
        /// <summary>
        /// Initialisation du Jeu :
        /// </summary>
        public static void InitStart()
        {   
            //Lance Les Ecrans du jeu :
            Initialise.Launch();
            //Lance La première mission du Jeu
            StartMissionTuto();
        }
        /// <summary>
        /// Mission Tutorielle : Début du jeu.
        /// </summary>
        public static void StartMissionTuto()
        {
            //Variable Initiales.
            bool Play = true;
            int Cpp = 0;
            int NumeroTour = 1;
            int LineInrapport = 1;
            bool TirObus = false;
            int ScoreInt = 0;
            int FondsInt = 0;
            //Initialisation des Navires : 
            Navire Player = new NavireJoueur();
            Navire Marchand00 = new NavireMarchand(25, 25, 'B', "Bleue");
            //Navire Marchand01 = new NavireMarchand(0, 0, 'B', "Bleue"); 
            //Initialisation des Ordres :
            //Version de départ : Peut être simplifiée.
            //TODO : Simplifier et passer directement les ordres en Rapport : 
            Rapport Ordre001 = new Rapport("Ordre Amirauté", $"Tour : {NumeroTour}", "Rendez-vous en (25;25)//Tirez Avec vos Obus.");
            string Ordre0101 = "Ordre de l'Amiral : Capitaine : Rendez-vous en (25;25) : Pour Mesurer vos Aptitudes.";
            string Ordre0102 = $"Tour numéro {NumeroTour} : Un navire immobilsé vous servira de cible. Tirez avec vos Obus.";
            //Initialisation des Listes :
            //Liste de Tous les Rapports :
            List<Rapport> AllRapports = new List<Rapport>();
            //Liste qui contiendra tous les navires de la partie.
            List<Navire> AllNavire = new List<Navire>();
            //Liste qui contient uniquement les navires Ennemis.
            List<Navire> EnnemiNavire = new List<Navire>();
            //TODO : Liste qui ne contiendra que les navires Alliés.
            AllRapports.Add(Ordre001);
            AllNavire.Add(Player);
            AllNavire.Add(Marchand00);
            //AllNavire.Add(Marchand01);
            EnnemiNavire.Add(Marchand00);
            //EnnemiNavire.Add(Marchand01);
            //Declaration des Ordres01 :
            //TODO : Supprimer et simplifier :
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Write.InRapport(Ordre0101, LineInrapport, 1);
            LineInrapport++;
            Write.InRapport(Ordre0102, LineInrapport, 1);
            LineInrapport++;
            Console.ForegroundColor = ConsoleColor.Gray;
            
            //Cheat Code : Pour les Tests :
            //Player.Teleportation(26, 26);

            //Boucle Update et Affiche de la Mission Tutorielle :

            while (Play == true)
            {
                //Compteur pour le Delta-Time : Raffraichissement de l'Ecran.
                Cpp++;
                if (Cpp == 100)
                {
                    //Affiche le Tour Actuel du Jeu.
                    Write.TourNumero("Tour Numéro : " + NumeroTour);
                    //Affiche Le Score et les Fonds du Joeur :
                    Write.Score(ScoreInt);
                    Write.Fonds(FondsInt);
                    //Faire Avancer le navire :
                    Player.Avance(Player.Direction);
                    //Mise à jour des Informations Joueurs dans l'écran Info.
                    UpdateInfoPlayer();
                    //Mises à Jour des Informations Listes des navires destinées à être vu par le joueur.
                    UpdateEnnemiNavireForPlayer();

                    //RéInitialisa des variables pour le tour suivant :
                    NumeroTour++;
                    Cpp = 0;
                    Draw.ClearAllUserMenu();
                    TirObus = false;
                }
                //Vérification des Touches Préssées par le Joueur :
                if (Console.KeyAvailable)
                {
                    switch (Console.ReadKey(true).Key)
                    {
                        //Attaquer un avion d'observation : 
                        case ConsoleKey.A:
            
                            break;
                        //Consulter les Rapports :
                        case ConsoleKey.C:
                            foreach (Rapport item in AllRapports)
                            {
                                Write.InRapport(item.ToString(),LineInrapport,1);
                                LineInrapport++;
                            }
                           
                            break;
                        //Donner des Ordres aux navires alliés :
                        case ConsoleKey.D:
                           
                            break;
                        //Etablir un Contact Radio avec :
                        case ConsoleKey.E:
                            
                            break;
                        //Fixer un cap poour une Direction et une Vitesse :
                        case ConsoleKey.F:
                            Write.InUserMenu("Fixer un cap : Entrer Une Direction Puis Entrer Une Vitesse :", 1, 70);
                            Write.InUserMenu("                Entrer une Direction [PAV NUM] puis [ENTRER]: ", 2, 70);
                            int pDirection = Convert.ToInt32(Console.ReadLine());
                            Write.InUserMenu("                Entrer une Vitesse [PAV NUM] puis [ENTRER]: ", 3, 70);
                            int pVitesse = Convert.ToInt32(Console.ReadLine());
                            Player.DonnerDirectionEtVitesse(pDirection, pVitesse);

                            break;
                        //Menu Gestion de L'Equipage :
                        case ConsoleKey.G:

                            break;
                        //Consulter l'Aide du Jeu :
                        case ConsoleKey.H:

                            break;
                        //Lancer une Torpille :
                        case ConsoleKey.L:

                            break;
                        //Pause :
                        case ConsoleKey.P:
                            Write.InUserMenu("Le Programme est en Pause : ", 1, 70);
                            Write.InUserMenu("Press [ANY KEY] Pour Relancer : ", 2, 70);
                            Console.ReadLine();
                            //Draw.ClearAllUserMenu();

                            break;
                        //Quiter le Programme :
                        case ConsoleKey.Q:

                            break;
                        //Retourner à la Base :
                        case ConsoleKey.R:

                            break;
                        //Sauvegarder la partie :
                        case ConsoleKey.S:

                            break;
                        //Tirer un Obus :
                        case ConsoleKey.T:
                            Write.InUserMenu("BOOM !", 1, 70);
                            TirObus = true;
                            foreach (Navire item in EnnemiNavire)
                            {
                                if (TirObus == true && item.FenetreDeTir == true)
                                {
                                    Write.InUserMenu("Navire Touché !", 2, 70);
                                    item.PrendreObusDansLaFace();
                                    Rapport ToucheNavire = new Rapport("Réussite du Tir : ", $"Tour : {NumeroTour}", $"{item.Nom} Touché en ({item.CoordonneeX};{item.CoordonneeY})");
                                    Write.InRapport(ToucheNavire.ToString(), LineInrapport, 1);
                                    LineInrapport++;
                                    ScoreInt = ScoreInt + 10;
                                    AllRapports.Add(ToucheNavire);
                                    if (item.EstDetruit)
                                    {
                                        Rapport Detruit = new Rapport("Destruction : ", $"Tour : {NumeroTour}", $"{item.Nom} Touché/Coulé en ({item.CoordonneeX};{item.CoordonneeY})");
                                        Write.InRapport(Detruit.ToString(), LineInrapport, 1);
                                        LineInrapport++;
                                        AllRapports.Add(Detruit);
                                        EnnemiNavire.Remove(item);
                                        ScoreInt = ScoreInt + 50;
                                        FondsInt = FondsInt + 500;
                                    }
                                    Write.InUserMenu("Plouf !", 2, 70);
                                    break;
                                }
                            }
                            Write.InUserMenu("Plouf Plouf ! ", 2, 70);

                            break;
                        //Utliser l'Hydophone :
                        case ConsoleKey.U:

                            break;
                    }
                }
                //Contraindre une pause pour l'affichage.
                Thread.Sleep(1000 / 60); 
            }
            //Fonction des Informations à Mettre à jour.
            void UpdateInfoPlayer()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Write.InNavireInfo("Type : " + Player.Nom, 1);
                Write.InNavireInfo($"Position : ({Player.CoordonneeX} ; {Player.CoordonneeY})", 2);
                Write.InNavireInfo("Dommages : " + Player.Etat, 3);
                Write.InNavireInfo("Direction : " + Player.DirectionToString, 4);
                Write.InNavireInfo("Vitesse : " + Player.VitesseToString, 5);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            //Fonction de l'Actialisation des informations Utilisées par le Joueur :
            void UpdateEnnemiNavireForPlayer()
            {
                //Affichage Ce que voit la Vigie :
                List<Navire> EnnemiEnVue = EnnemiNavire.FindAll(x => x.EstDetruit == false);
                if (EnnemiEnVue.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Write.Vigie("Vigie : R.A.S.");
                }
                foreach (Navire item in EnnemiEnVue)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    if (item != Player)
                    {
                        Player.DistanceAvecNavire(item);
                        Write.Vigie(Player.MessagePorteeVision);
                        if (Player.ObjetPorteeObus)
                        {
                            Write.Vigie(Player.MessagePorteeObus);
                        }
                    }
                }
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
//Rapport NavireEnVue = new Rapport("Navire En Vue : ", $"Tour : {NumeroTour}", $"{item.Nom}, {item.DrapeauToString} Vue en ({item.CoordonneeX};{item.CoordonneeY}) " +
//                                                      $"\n Etat : {item.Etat} // Vitesse : {item.Vitesse} // Direction {item.DirectionToString}");
//Write.InRapport(NavireEnVue.ToString(), LineInrapport, 1);
//LineInrapport= LineInrapport+2;
//AllRapports.Add(NavireEnVue);


//foreach (Navire item in EnnemiNavire.FindAll(x => x.EstDetruit == true))
//{
//    Console.ForegroundColor = ConsoleColor.DarkYellow;

//        Write.Vigie("Il n'y a plus personne ici");
//        //if (Player.ObjetPorteeObus == true)
//        //{
//        //    Write.Vigie(Player.MessagePorteeObus);
//        //}

//}
//if (EnnemiNavire.Exists())
//{
//    Write.Vigie("Coucou les amis !");
//    Console.ForegroundColor = ConsoleColor.Gray;
//}
//Write.Vigie("RAS (Tu vas marcher : Oui ?");