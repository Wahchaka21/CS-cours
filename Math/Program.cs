using System;

namespace MyApp
{
    internal class Program
    {
        //petit équivalent du math.random()
        static double NextRandomRange(double minimum, double maximum)
        {
            Random rand = new Random();
            return rand.NextDouble() * (maximum - minimum) + minimum;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine(NextRandomRange(1, 1000));
            //Math.round() c'est comme en js, c'est pour arrondir à l'entier le plus proche
            System.Console.WriteLine(Math.Round(NextRandomRange(10, 20)));
            //retourne la plus grande valeur entre x et y
            System.Console.WriteLine(Math.Max(5, 10));
            //retourne la plus petite valeur entre x et y
            System.Console.WriteLine(Math.Min(5, 10));
            //renvoie la racine carrée de x
            System.Console.WriteLine(Math.Sqrt(64));
            //renvoie la valeur positive de x
            System.Console.WriteLine(Math.Abs(-6));
        }
    }
}