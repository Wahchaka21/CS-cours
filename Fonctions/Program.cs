using System;
using System.Security.Cryptography;
namespace firstProgramme
{
    internal class Program
    {
        //on peut reprendre le principe vu dans "Variables_et_Boucles" pour demander l'age d'une personne mais cette fois avec une fonction, comme ça
        //je pourrais par exemple créer une variable age_num et lui assigner la fonction DemanderAge();
        //on va décaler une fonction en dehors de la fonction main, car c'est la fonction main qui est appeller à chaque "dotnet run"
        static int DemanderAge()
        {
            int age_int2 = 0;
            bool ageValide = false;
            while (ageValide == false)
            {
                System.Console.WriteLine("Quel est ton age ?");
                string monAge2 = Console.ReadLine();
                try
                {
                    age_int2 = int.Parse(monAge2);
                    if (age_int2 <= 0)
                    {
                        System.Console.WriteLine("Erreur, vous devez rentrer un age valide !");
                        ageValide = false;
                    }
                    else if (age_int2 < 18)
                    {
                        System.Console.WriteLine("Vous devez être majeur, or vous avez " + age_int2 + " ans. Vous ne pouvez pas acceder à cette application.");
                        Environment.Exit(0); // ou return 0 ou return -1 pour arrêter le programme
                    }
                    else
                    {
                        ageValide = true;
                        int add_age = age_int2 + 1;
                        System.Console.WriteLine("Votre age est : " + age_int2);
                        System.Console.WriteLine("Vous aurez bientot : " + add_age);
                    }
                }
                catch
                {
                    System.Console.WriteLine("Erreur, vous devez rentrer un age valide !");
                }
            }
            //on va retourner les résultat
            return age_int2;
        }
        static void Main(string[] args)
        {
            string nom = "";
            while (nom == "")
            {
                System.Console.WriteLine("Quel est ton nom ? ");
                nom = Console.ReadLine();
                nom = nom.Trim();
                if (nom == "")
                {
                    System.Console.WriteLine("Erreur : le nom ne doit pas être vide");
                }
            }

            //et du coup dans le main on peut déclarer notre fonction :
            int age = DemanderAge();

            // et ensuite je vais utiliser ma variable age :
            System.Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + age + " ans.");
            int age_prochain = age + 1;
            System.Console.WriteLine("Bientôt vous aurez " + age_prochain + " ans.");
        }
    }
}