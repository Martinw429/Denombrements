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
            while (choix != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = int.Parse(Console.ReadLine());

                if (choix == 0) { Environment.Exit(0); }

                if (choix == 1)
                {
                    Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                    int nombre = int.Parse(Console.ReadLine()); // saisir le nombre
                                                                // calcul de resultat
                    long resultat = 1;
                    for (int k = 1; k <= nombre; k++)
                        resultat *= k;
                    Console.WriteLine(nombre + "! = " + resultat);
                }
                else
                {
                    if (choix == 2)
                    {
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int total = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        int nombre = int.Parse(Console.ReadLine()); // saisir le nombre
                        // calcul de r
                        long resultat = 1;
                        for (int k = (total - nombre + 1); k <= total; k++)
                            resultat *= k;
                        //Console.WriteLine("résultat = " + (resultat1 / resultat2));
                        Console.WriteLine("A(" + total + "/" + nombre + ") = " + resultat);
                    }
                    else
                    {
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int total = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        int nombre = int.Parse(Console.ReadLine()); // saisir le nombre
                        // calcul de resultat1
                        long resultat1 = 1;
                        for (int k = (total - nombre + 1); k <= total; k++)
                            resultat1 *= k;
                        // calcul de resultat2
                        long resultat2 = 1;
                        for (int k = 1; k <= nombre; k++)
                            resultat2 *= k;
                        // calcul de r3
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("C(" + total + "/" + nombre + ") = " + (resultat1 / resultat2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}