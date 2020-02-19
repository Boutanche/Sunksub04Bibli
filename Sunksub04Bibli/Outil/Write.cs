using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Sunksub04Bibli.Outil
{
    class Write
    {
        //Ecriture Stylisée : Telex :
        public static void Telex(string pString)
        {
            Random random = new Random();
            Console.Write("");
            foreach (char caracterre in pString)
            {
                Console.Write("\b");
                Console.Write(caracterre);
                Console.Write("#");
                Thread.Sleep(random.Next(10, 50));
            }
            Console.Write("\b");
        }
        //Ecriture Stylisée : Lettre Manuscrite :
        public static void Dactilo(string pString)
        {
            Random random = new Random();
            Console.WriteLine("");
            foreach (char caracterre in pString)
            {
                Console.Write("\b");
                Console.Write(caracterre);
                Console.Write("#");
                Thread.Sleep(random.Next(10, 50));
            }
            Console.Write("\b");
        }
        //Mise en Page Standardisée :
        public static void CentrerLeTexteEnLongueur(string texte)
        {
            int nbEspace = (Console.WindowWidth - texte.Length) / 2;
            Console.SetCursorPosition(nbEspace, Console.CursorTop);
            Console.WriteLine(texte);
        }
        public static void CentrerLeTexteHauteur(string texte)
        {
            int nbEspace = (Console.WindowHeight - 1) / 2;
            Console.SetCursorPosition(Console.CursorLeft, nbEspace);
            Console.WriteLine(texte);
        }
        public static void MilieuFenetre(string texte)
        {
            int nbEspaceLarge = (Console.WindowWidth - texte.Length) / 2;
            int nbEspaceMilieu = (Console.WindowHeight - 1) / 2;
            Console.SetCursorPosition(nbEspaceLarge, nbEspaceMilieu);
            Console.WriteLine(texte);
        }
        public static void BasDroite(string texte)
        {
            Console.SetCursorPosition((Console.WindowWidth - texte.Length), (Console.WindowHeight - 1));
            Console.WriteLine(texte);
        }
        public static void BasGauche(string texte)
        {
            Console.SetCursorPosition((1), (Console.WindowHeight - 5));
            Console.WriteLine(texte);
        }
        
        //Console de Jeu Spéciale SunkSubMMersible :
        public static void TourNumero(string pString)
        {
            Console.SetCursorPosition(5, 0);
            Console.Write(pString);
        }
        public static void InRapport(string pString, int Ligne , int position)
        {
            Console.SetCursorPosition(2+position, 2+Ligne);
            Console.Write(pString);
        }
        public static void InNavireInfo(string pString, int Ligne)
        {
            Console.SetCursorPosition(113, 2 + Ligne);
            Console.Write(pString);
        }
        public static void Score(int score)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(115, 30);
            Console.Write("Score : " + score);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void Fonds (int fonds)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(135, 30);
            Console.Write("$Fonds : " + fonds);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void InUserMenu(string pString, int Ligne, int x)
        {
            Console.SetCursorPosition(x, 40 + Ligne);
            Console.Write(pString);
        }
        public static void Vigie(string pString)
        {
            Console.SetCursorPosition(113, 29);
            Console.Write("                                     ");
            Console.SetCursorPosition(113, 29);
            Console.Write(pString);
        }

    }
}
