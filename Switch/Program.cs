using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* L'expression switch est évaluée une seule fois. Sa valeur est comparée aux valeurs de chaque cas.
            En cas de correspondance, le bloc de code associé est exécuté.
            Syntax : */
            switch (expression)
            {
                case x:
                    // code block
                    break;
                case y:
                    // code block
                    break;
                default:
                    // code block
                    break;
            }

            //exemple :
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break; //break stop l'execution de la switch, ça interrompt l'exécution du reste du code, une fois une correspondance est trouvée le bloc break est exécuté.
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            // Outputs "Thursday" (day 4)

            //il y a également "default" :
            int day2 = 4;
            switch (day2)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default: // en gros c'est si y a pas de correspondance, comme ici il n'y a pas "case 4" et bien la réponse par défaut est le bloc default
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
            // Outputs "Looking forward to the Weekend."
        }
    }
}