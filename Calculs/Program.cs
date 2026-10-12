using System;

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
            int reponse; // saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilsiateur

            // boucle sur le menu
            choix = 1;
            while (choix != 0)
            {
                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                
                bool correct = false;
              

                while (!correct)
                {
                    try
                    {
                        Console.Write("Choix :                          ");
                        choix = int.Parse(Console.ReadLine());

                        if (choix != 0)
                        {
                            if (choix == 1)
                            {
                                correct = true;
                                // choix de l'addition
                                val1 = rand.Next(1, 10);
                                val2 = rand.Next(1, 10);
                                // saisie de la réponse
                                Console.Write(val1 + " + " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
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
                            }
                            else if (choix == 2)
                            {
                                correct = true;
                                // choix de la multiplication
                                val1 = rand.Next(1, 10);
                                val2 = rand.Next(1, 10);
                                // saisie de la réponse
                                Console.Write(val1 + " x " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
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
                            }
                            else
                            {
                                Console.WriteLine("Erreur de saisie, retour au menu.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Arrêt en cours ...");

                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine();
                            Console.WriteLine("A très bientôt ! (Appuyez sur une touche pour quitter le programme)");

                            Console.ReadKey();

                            Environment.Exit(0);

                        }
                    }
                    catch
                    {
                        Console.WriteLine("Erreur de saisie, retour au menu.");

                    }

                }

                // traitement des choix
            }
        }
    }
}
