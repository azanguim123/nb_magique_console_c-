using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int min = 1;
            const int max = 10;
            Console.WriteLine("Ce programme permet de trouver un nombre magique compris dans l'interval " + min + " et " + max);
            Random random = new Random();
            //random.Next(min, max);
            int nombreMagique = random.Next(min, max) ;
            int nombreDeTentative = 4;

            while (nombreDeTentative > 0)
            {
                Console.Write("Devinez le nombre magique (Il vous reste " + nombreDeTentative + " tentative):");
                string nombre = Console.ReadLine(); // nombre entree par l'utilisateur(chaine de charactere)
                int nombreEntree = 0;
                if (int.TryParse(nombre, out nombreEntree) == true)// fonction permettant de convertir les strings en interger.
                {
                    if ((nombreEntree < min) || (nombreEntree > max)) // le nombre entree doit etre dans l'etervalle min et max
                    {
                        Console.Write("Le nombre entree n'est pas dans l'intervalle " + min + " et " + max + ". Veillez entrer un autre nombre");
                    }
                    else
                    {
                        //la conversion s'est bien passee
                        if (nombreEntree < nombreMagique)
                        {
                            Console.WriteLine("Mauvaise reponse,le nombre magique est superieur a votre nombre.");
                        }
                        else if (nombreEntree > nombreMagique)
                        {
                            Console.WriteLine("Mauvaise reponse. Le nombre magique est inferieur a votre nombre.");
                        }
                        else
                        {
                            //Egalite et vitoire
                            Console.WriteLine("Bravo!!! Bonne Reponse. Vous avez trouve le nombre magique.");
                            break;
                        }
                        nombreDeTentative--;  // decrementation du nombre de tentative.
                    }
                }
                else
                {
                    //Erreur de convesion
                    Console.WriteLine("La commande entree n'est pas un nombre. Il vous reste " + nombreDeTentative + " tentative. Veillez entrer un nombre s'il vous plait. ");
                }
                Console.WriteLine("");
                
            }
            //nomre de tentative atteint sorti de la boucle
                if (nombreDeTentative == 0)
            { 
                Console.WriteLine("Desole nombre de tentative atteint vous avez perdu.Le nombre magique etait: " + nombreMagique + ". Vous auriez plus de chance la prochaine fois.");
            }

        }
    }
}