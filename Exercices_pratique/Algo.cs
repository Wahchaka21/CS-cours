using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercices_pratique
{
    public class Algo
    {
        static int RandomInt(int minimum, int maximum)
        {
            Random rand = new Random();
            return rand.Next(maximum - minimum + 1);
        }
        public static void DevineLeNombre()
        {
            int monNombreInt = 0;
            int nombreMystere = RandomInt(0, 50);
            bool BonneReponse = false;
            while (BonneReponse == false)
            {
                System.Console.WriteLine("Le chiffre/nombre mystère ce trouve entre 0 et 50.");
                System.Console.WriteLine("Quel est le chiffre ou le nombre que tu as choisi ?");
                string monNombre = Console.ReadLine();
                try
                {
                    monNombreInt = int.Parse(monNombre);
                    if (monNombreInt < 0)
                    {
                        System.Console.WriteLine("La réponse ne peux pas être en dessous de 0.");
                        BonneReponse = false;
                    }
                    else if (monNombreInt > 50)
                    {
                        System.Console.WriteLine("La réponse ne peux pas être au dessus de 50 !");
                        BonneReponse = false;
                    }
                    else if (monNombreInt < nombreMystere)
                    {
                        System.Console.WriteLine("C'est plus !");
                        BonneReponse = false;
                    }
                    else if (monNombreInt > nombreMystere)
                    {
                        System.Console.WriteLine("C'est moins !");
                        BonneReponse = false;
                    }
                    else if (monNombreInt == nombreMystere)
                    {
                        System.Console.WriteLine("Bien jouer tu as trouvé !");
                        BonneReponse = true;
                    }
                }
                catch
                {
                    System.Console.WriteLine("Erreur pendant le programme");
                }
            }
        }
    }
}