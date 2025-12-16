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
                                                           // calcul de r
                    long r = 1;
                    for (int k = 1; k <= nombre; k++)
                        r *= k;
                    Console.WriteLine(nombre + "! = " + r);
                }
                else
                {
                    if (choix == 2)
                    {
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int t = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        int nombre = int.Parse(Console.ReadLine()); // saisir le nombre
                        // calcul de r
                        long r = 1;
                        for (int k = (t - nombre + 1); k <= t; k++)
                            r *= k;
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("A(" + t + "/" + nombre + ") = " + r);
                    }
                    else
                    {
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int t = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        int nombre = int.Parse(Console.ReadLine()); // saisir le nombre
                        // calcul de r1
                        long r1 = 1;
                        for (int k = (t - nombre + 1); k <= t; k++)
                            r1 *= k;
                        // calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= nombre; k++)
                            r2 *= k;
                        // calcul de r3
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("C(" + t + "/" + nombre + ") = " + (r1 / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
