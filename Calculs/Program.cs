﻿using System;

namespace Calculs
{
    /// <summary>
    /// Application Calculs : addition ou multiplication de 2 nombres
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse = 0; // saisie de la réponse de l'utilisateur
            string choix; // saisie du choix de l'utilsiateur
            bool correct;
            

            // boucle sur le menu
            choix = "1";
            while (choix != "0")
            {
                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");
                choix = Console.ReadLine();


                // saisie des valeurs
                val1 = rand.Next(1, 10);
                val2 = rand.Next(1, 10); 
                // traitement des choix
                switch (choix)
                {
                    case "1":
                        // addition

                        correct = false;
                        // saisie de la réponse
                        while (!correct)
                        {
                            try
                            {
                                Console.Write(val1 + " + " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Entrer un nombre entier ");
                            }
                        }                       
                        // comparaison avec la bonne réponse
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                        }
                        break;
                    case "2":
                        // choix de la multiplication

                        correct = false;
                        // saisie de la réponse
                        while (!correct)
                        {
                            try
                            {
                                Console.Write(val1 + " x " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Entrer un nombre entier");
                            }
                        }
                        
                        // comparaison avec la bonne réponse
                        solution = val1 * val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                        }
                        break;
                    case "0": //demande de fin de programme
                        break;
                    default:
                        Console.WriteLine("Erreur");
                        break;                       
                }
            }
        }
    }
}

