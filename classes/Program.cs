using System;
//on importe la namespace du fichier NewClassExample.cs sinon ça ne fonctionne pas
using classes;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*class = du code pouvant être utilisé comme schéma pour créer des object
            par exemple les Math.Round(), Math.Abs() viennes de la class Math qui est une classe contenant du code relatif au mathématique */
            //on peut créer notre propre classe => se rendre dans message.cs
            //puis une fois créer, on peut les appelé ici =>
            NewClassExample.Hello();
            NewClassExample.Waiting();
            NewClassExample.Bye();
        }
    }
}