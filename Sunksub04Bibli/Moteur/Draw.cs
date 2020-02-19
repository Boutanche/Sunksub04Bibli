using Sunksub04Bibli.Outil;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sunksub04Bibli.Moteur
{
    class Draw
    {
        public static void DrawLicenceScreen()
        {
            //Write.Dactilo(" Attention Chargement : ... " +
            //    "Lancement de l'application " +
            //    "... Fin de Chargement : ");
            Write.CentrerLeTexteEnLongueur("* Jeu réalisé durant " +
                                      "la formation CDA à 2ISA *");
            Write.MilieuFenetre("//SunkSubMMerSible//");
            int x = Console.CursorTop;
            string texte = "* Bataille Navale *";
            string pressStart = "(Press Start)";
            Console.SetCursorPosition((80 - texte.Length) / 2, x);
            Console.WriteLine(texte);
            Console.SetCursorPosition((80 - pressStart.Length) / 2, x + 1);
            Console.WriteLine(pressStart);
            Write.BasDroite("BenoitCDA (c) 2020. ");
            Console.ReadKey(true);
            Console.Clear();
        }
        public static void DrawTitleScreen()
        {
            string localisation = System.IO.Path.GetFullPath(@"Title.txt");
            string[] txtTitre = System.IO.File.ReadAllLines(localisation);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            foreach (string line in txtTitre)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Write.CentrerLeTexteEnLongueur(line);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Write.MilieuFenetre("Commencer une nouvelle partie : Appuyer sur [ENTRER]");
            Console.WriteLine("");
            Write.CentrerLeTexteEnLongueur(" Un jour, vous pourrez charger votre ancienne partie... Mais pas aujourd'hui.");
            Console.ReadLine();
            Console.Clear();
        }
        public static void DrawStartMission()
        {
            string localisation = System.IO.Path.GetFullPath(@"Title.txt");
            string[] txtTitre = System.IO.File.ReadAllLines(localisation);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            foreach (string line in txtTitre)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Write.CentrerLeTexteEnLongueur(line);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("                                     Bonjour, Capitaine: ");
            Console.WriteLine("");
            Write.Dactilo("             Votre mission du jour est un entrainement : ");
            Write.Dactilo("             Veuillez nous prouvez que vous êtes apte à commander nos forces navales.");
            Write.Dactilo("             Vous devez en priorité couler les navires marchands qui possèdent un drapeau Bleu.");
            Write.Dactilo("             Prouvez-nous au minimum que vous savez distinguer les couleurs et que vous ne coulerez pas les navires portant le drapeau Rouge. ");
            Console.WriteLine("");
            Write.Dactilo("             Attention : ");
            Write.Dactilo("             Méfiez vous des navires de guerre de la nation Bleue");
            Write.Dactilo("             Non seulement ces derniers s'attaquent à nos convois. Mais ils peuvent aussi vous attaquer.");
            Write.Dactilo("             Vous dépasseriez nos espèrances en protégeants nos convoits.");
            Write.Dactilo("             Remplissez votre mission dans les plus brefs délais.");
            Write.Dactilo("             Cordialement,");
            Console.WriteLine("");
            Write.Dactilo("                                                                                                                               Amiral Gregoire.");
            Console.WriteLine("");
            Console.WriteLine("");
            Write.CentrerLeTexteEnLongueur("Appuyer sur [ENTRER] pour lancer la Mission :");
            Console.Read();
            Console.Clear();
        }
        public static void DrawScreenGame()
        {
            DrawTemplateRapport();
            DrawTemplateInfo();
            DrawTemplateUserMenu();
        }
        public static void DrawTemplateRapport()
        {
            int sizeX = 109;
            int sizeY = 39;
            int xDepart = 1;
            int xFin = 110;
            int yDepart = 1;
            int yFin = 39;
            HorizontalLine(yDepart, xDepart, sizeX +2, '*');
            VerticalLine(xDepart, yDepart, sizeY, '*');
            HorizontalLine(yFin, xDepart, sizeX +2, '*');
            VerticalLine(xFin, yDepart, sizeY, '*');
            Write.TourNumero("Tour Numéro : 0");
            Console.WriteLine();
            
        }
        public static void DrawTemplateInfo()
        {
            int sizeX = 49;
            int sizeY = 39;
            int xDepart = 111;
            int xFin = 154;
            int yDepart = 1;
            int yFin = 39;
            string titreInfo = "~~Informations du Navire~~";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            HorizontalLine(yDepart, xDepart, sizeX-4, '°');
            VerticalLine(xDepart, yDepart, sizeY, '°');
            HorizontalLine(yFin, xDepart, sizeX-4, '°');
            VerticalLine(xFin, yDepart, sizeY, '°');
            Console.SetCursorPosition(111 + 9,(1));
            Console.Write(titreInfo);
            Console.ForegroundColor = ConsoleColor.Red;
            Write.Score(0);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Write.Fonds(0);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Write.InNavireInfo("                                        ", 29);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Write.InNavireInfo("DIRECTION  ||  ALLURE DU NAVIRE         ", 30);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Write.InNavireInfo("O ", 31);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("N O R D");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("  ||                           ");
            Write.InNavireInfo("U 7 8 9 E  ||  STOP    :       [5]      ", 32);
            Write.InNavireInfo("E 4 5 6 S  ||  ARRIERE : [ ] 4 3 2 1    ", 33);
            Write.InNavireInfo("S 1 2 3 T  ||  VITESSE = (°) 1 2 3 4    ", 34);
            Write.InNavireInfo("T ", 35);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("S U D °  ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("||  AVANT   : [ ] 6 7 8 9    ");
            Write.InNavireInfo("                                        ", 36);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public static void DrawTemplateUserMenu()
        {
            int sizeX = 152;
            int sizeY = 10;
            int xDepart = 1;
            int xFin = 154;
            int yDepart = 40;
            int yFin = 48;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            HorizontalLine(yDepart, xDepart, sizeX +2, '-');
            //VerticalLine(xDepart, yDepart, sizeY, '°');
            HorizontalLine(yFin, xDepart, sizeX +3, '-');
            //VerticalLine(xFin, yDepart, sizeY, '°');
            Write.InUserMenu("-- Menu Utilisateur -- [PRESSEZ LA TOUCHE INDIQUEE] --", 0, 50);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            Write.InUserMenu("[A] : Abattre un Avion               | [L] : Lancer Torpille       |",1,1);
            Write.InUserMenu("[C] : Consultez Rapports             | [P] : Pause                 |",2,1);
            Write.InUserMenu("[D] : Donner Ordre à Un Autre Navire | [Q] : Quitter Programme     |",3,1);
            Write.InUserMenu("[E] : Etablir Contact Radio          | [R] : Retourner à la Base   |",4,1);
            Write.InUserMenu("[F] : Fixer Nouveau Cap              | [S] : Sauvegarder la Partie |",5,1);
            Write.InUserMenu("[G] : Gestion de l'Equipage          | [T] : Tirer un Obus         |",6,1);
            Write.InUserMenu("[H] : Consultez l'Aide               | [U] : Utiliser Hydrophone   |",7,1);

        }
       
        static void VerticalLine(int x, int yDebut, int yFin, char marque)
        {
            Console.SetCursorPosition(x, yDebut);
            for (int i = 0; i < yFin; i++)
            {
                Console.Write(marque);
                Console.SetCursorPosition(x, yDebut + i);
            }
        }
        static void HorizontalLine(int y, int xDebut, int xFin, char marque)
        {
            Console.SetCursorPosition(xDebut, y);
            for (int i = 0; i < xFin; i++)
            {
                Console.Write(marque);
                Console.SetCursorPosition(xDebut + i,y);
            }
        }
        public static void ClearAllUserMenu()
        {
            Write.InUserMenu("                                                                      ", 1, 70);
            Write.InUserMenu("                                                                      ", 2, 70);
            Write.InUserMenu("                                                                      ", 3, 70);
            Write.InUserMenu("                                                                      ", 4, 70);
            Write.InUserMenu("                                                                      ", 5, 70);
            Write.InUserMenu("                                                                      ", 6, 70);
            Write.InUserMenu("                                                                      ", 7, 70);
        }
    }
}
