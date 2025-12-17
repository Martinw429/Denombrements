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
                        nombre = int.Parse(Console.ReadLine()); // saisir le nombre

                        int total = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble

                                                                                    // calcul de resultat
                        for (int k = (total - nombre + 1); k <= total; k++)
                           resultat *= k;
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("A(" + total + "/" + nombre + ") = " + resultat);
                        break;
                    case 3:
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        nombre = int.Parse(Console.ReadLine()); // saisir le nombre
                        int total = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                                                                    // calcul de r1
                        long r1 = 1;
                        for (int k = (total - nombre + 1); k <= total; k++)
                            r1 *= k;
                        // calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= nombre; k++)
                            r2 *= k;
                        // calcul de r3
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("C(" + total + "/" + nombre + ") = " + (r1 / r2));
                        break;
                    default:
                        Console.WriteLine("Veuillez saisir un entier");
                        break;
                }

            } while (choix != 0);
            Console.ReadLine();
        }
    }
}
