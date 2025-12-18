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
            //savoir combien de lettre à un mot
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            System.Console.WriteLine("la varibale txt à : " + txt.Length + " lettre");
            //mettre en maj
            string name = "Frieren";
            System.Console.WriteLine(name.ToUpper());
            System.Console.WriteLine(name.ToLower());
            //au lieu de faire des + (concaténation) on peut faire ça :
            string firstName = "Artoria";
            string lastName = "Pendragon";
            string fullName = $"je me nomme : {firstName} {lastName}";
            System.Console.WriteLine(fullName);
            //avoir acces à une lettre
            string a = "Guts";
            System.Console.WriteLine(a[1]);
            //savoir combien de fois une lettre est répété
            string b = "coucou";
            System.Console.WriteLine(b.IndexOf("u"));



            //petite astuce, taper cw puis appuis sur tab 1 fois et ça écrit Console.WriteLine();
            //boucle while :
            int i = 0;
            while (i <= 10)
            {
                System.Console.WriteLine("Boucle while : valeur de i : " + i);
                i++; // on peut très bien l'écrire i = i + 1 ou i += 1
            }

            System.Console.WriteLine("Boucle while : fin de la boucle, la dernière valeur de i est : " + i);

            //boucle for :
            for (int j = 0; j <= 10; j++)
            {
                System.Console.WriteLine("Boucle for : valeur de j : " + j);
            }

            //boucle forEach, pour les tableaux
            string[] cars = { "Ciroen", "Peugeot", "Renault" };
            foreach (string k in cars)
            {
                System.Console.WriteLine(k);
            }



            //avec ce principe, on peut faire un programme pour demander l'age de la personne :
            //on créer bool ageValde qui commence à false, la boucle tourne tant que ageValide est false, si le Parse réussit, on met ageValide = true et la boucle s'arrête
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