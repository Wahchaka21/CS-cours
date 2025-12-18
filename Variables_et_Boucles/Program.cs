using System;
using System.Security.Cryptography;
namespace firstProgramme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pour déclarer une varible, il suffit premièrement de déclarer son type, puis son nom
            string String = "Frieren";
            //int pour les nombres
            int Number = 1000;
            //float pour le nombres à virgule... faut même rajouter un f à la fin du nombre...
            float FloatingNumber = 1256.5189f;
            // et bool pour déclarer une varibale boolean
            bool BooleanVariable = true;
            Console.WriteLine("Salut " + String + " j'ai " + Number + " ans moi aussi et j'ai " + FloatingNumber + " points de mana " + BooleanVariable);





            //petite astuce, taper cw puis appuis sur tab 1 fois et ça écrit Console.WriteLine();
            //il y a une ligne de code qui nous permet de lire la console par exemple :
            System.Console.Write("Quel est votre nom ?"); //on va juste mettre Write
            string leNom2 = Console.ReadLine(); //enfaite ça va ouvrir la console, et je n'aurai que à taper le nom de la personne et ça va l'assigner à la variable
            System.Console.Write("et quel est ton âge ?");
            string age_str = Console.ReadLine();
            System.Console.WriteLine("donc vous vous applez " + leNom2 + " et vous avez " + age_str + " ans");
            //int.Pars() est pour convertir une str en int car, console.ReadLine() ne renvoie que une string et non un nombre, donc on ne peut pas faire par exemple :
            //int age = Console.ReadLine(), ça serai faux, il faudrait mettre string. Donc pour palier à ce problème on déclare d'abord la lecture de la console dans un string :
            //string age_str = Console.ReadLine(); puis on passe cette variable à une nouvelle variable qui va remplacer le type string de age_str par un type int comme ceci :
            int age_num = int.Parse(age_str); //par contre ça marche que si on rentre un nombre, si on decide d'écrire une string, ça plante
            int age_prochain = age_num + 1;
            System.Console.WriteLine("Vous aurez le 28 juin 2026 : " + age_prochain + " ans");





            //mais du coup cette façon de faire n'est pas opti, car l'utilisateur pourrais très bien rentrer un age invalide ou une string, il faut donc gérer les exceptions
            //donc comme en js, on peut faire des try et catch, donc on va recommencer une simulation :
            System.Console.WriteLine("Quel est ton age ?");
            string monAge = Console.ReadLine();
            try
            {
                int age_int = int.Parse(monAge);
                int add_age = age_int + 1;
                System.Console.WriteLine("Votre age est : " + age_int);
                System.Console.WriteLine("Vous aurez bientot : " + add_age);
            }
            catch
            {
                System.Console.WriteLine("Erreur, vous devez rentrer un age valide !");
            }





            //mais ça serai bien que par exemple si le user rentre un string ou un age invalide, au lieu de juste lui mettre le message d'erreur, ça lui redemande son age juste après
            //donc pour ça il faut faire des boucle, voici un exemple de boucle while en C# :
            int i = 0;
            while (i <= 10)
            {
                System.Console.WriteLine("Valeur de i : " + i);
                i++; // on peut très bien l'écrire i = i + 1 ou i += 1
            }

            System.Console.WriteLine("fin de la boucle, la dernière valeur de i est : " + i);

            //avec ce principe, on peut reprendre l'exemple plus haut pour demander l'age de la personne :
            //on créer bool ageValde qui commence à false, la boucle tourne tant que ageValide est false, i le Parse réussit, on met ageValide = true et la boucle s'arrête
            //si le Parse échoue, on va dans le catch, on affiche l'erreur, et la boucle recommence
            int age_int2 = 0;
            bool ageValide = false;
            while (ageValide == false)
            {
                System.Console.WriteLine("Quel est ton age ?");
                string monAge2 = Console.ReadLine();
                try
                {
                    age_int2 = int.Parse(monAge2);
                    //on peut même renforcer le programme, avec un if, else, parce que sans ça, il pourrais très bien troll et mettre 0 et le programme ferai 0 + 1
                    if (age_int2 <= 0)
                    {
                        System.Console.WriteLine("Erreur, vous devez rentrer un age valide !");
                        ageValide = false;
                    }
                    //pour faire une autre condition, commen en js avec un else if
                    else if (age_int2 < 18)
                    {
                        System.Console.WriteLine("Vous devez être majeur, or vous avez " + age_int2 + " ans. Vous ne pouvez pas acceder à cette application.");
                        return;
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
        }
    }
}