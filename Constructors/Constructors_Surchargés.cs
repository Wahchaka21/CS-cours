using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Constructors
{
    public class Constructors_Surchargés
    {
        //les constructeurs surchargés sont une technique pour créer plusieurs constructeurs avec différents paramètres.
        // nom + paramètres = signature unique
        public string bread;
        public string sauce;
        public string cheese;
        public string topping;

        public Constructors_Surchargés(string bread, string sauce, string cheese, string topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
        //avec ce constructeur, je suis obliger par exemple de remplir le champ "topping", il faut donc faire un autre constructeur =>
        public Constructors_Surchargés(string bread, string sauce, string cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        //pareil si on ne veux pas de fromage =>
        public Constructors_Surchargés(string bread, string sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }
        //etc...
        public void Commande()
        {
            System.Console.WriteLine("Commande => Pâte: " + bread + ", Sauce: " + sauce + ", Fromage: " + cheese + ", garniture: " + topping);
        }
    }
}