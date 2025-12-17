using System;

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable 
            int choix = 1;

            /// Code permettant de faire des calculs de permutation/arrangement/combinaison sur la console.

            do
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = int.Parse(Console.ReadLine());
                if ((choix >= 0) && (choix <= 3))
                {
                    switch (choix)
                    {
                        case 1:
                            Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                            int nombre = int.Parse(Console.ReadLine()); // saisir le nombre
                                                                        // calcul de resultat
                            long resultat = 1;
                            for (int k = 1; k <= nombre; k++)
                                resultat *= k;
                            Console.WriteLine(nombre + "! = " + resultat);
                            break;

                        case 2:
                            Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                            int total = int.Parse(Console.ReadLine()); // saisir le nombre
                            Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                            nombre = int.Parse(Console.ReadLine()); // saisir le nombre

                            // calcul de resultat
                            long resultatArrangement = 1;
                            for (int k = (total - nombre + 1); k <= total; k++)
                                resultatArrangement *= k;
                            //Console.WriteLine("résultat = " + (r1 / r2));
                            Console.WriteLine("A(" + total + "/" + nombre + ") = " + resultatArrangement);
                            break;
                        case 3:
                            Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                            int total3 = int.Parse(Console.ReadLine()); // saisir le nombre
                            Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                            nombre = int.Parse(Console.ReadLine()); // saisir le nombre                                                             // calcul de r1
                            long resultat1 = 1;
                            for (int k = (total3 - nombre + 1); k <= total3; k++)
                                resultat1 *= k;
                            // calcul de resultat2
                            long resultat2 = 1;
                            for (int k = 1; k <= nombre; k++)
                                resultat2 *= k;
                            // calcul de r3
                            //Console.WriteLine("résultat = " + (r1 / r2));
                            Console.WriteLine("C(" + total3 + "/" + nombre + ") = " + (resultat1 / resultat2));
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Veuillez saisir un entier entre 0 et 3");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Veuillez saisir un entier entre 0 et 3");
                }


            } while (choix != 0);
            Console.ReadLine();
        }
    }
}
