using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //un constructeur est une méthode spécial dans une classe.

            //on va reprendre les mêmes exemples que dans le dossier object =>

            Human human1 = new Human("Guts", 23);

            //donc ici ces deux lignes ne servent plus à rien, vu que j'ai fait un construceur plus bas, je n'ai qu'à les passer en paramètre plus haut.
            // human1.name = "Guts";
            // human1.age = 23;

            human1.Eat();
            human1.Sleep();
            human1.NameAge();

            Human human2 = new Human("Frieren", 1227);

            //idem ici, ça ne sert plus à rien
            // human2.name = "Frieren";
            // human2.age = 1227;

            human2.Eat();
            human2.Sleep();
            human2.NameAge();

        }
    }
    class Human
    {
        public string name;
        public int age;

        //ici le constructeur est créée, il faut qu'il est le même nom que la class =>
        //par exemple dans ce constructeur je passe directement les variable name et age, ça me permet de ne plus à avoir les déclarer à la main
        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;

            //on peut également faire d'autre chose, je pourrais faire que à chaque fois que je fait new Human() ça joue les fonction comme ce ceci =>
            // Eat();
            // Sleep();
            // NameAge();
            //Mais je ne pense pas que ce soit très pertinent ici, car le problème ce qu'on ne pourrais plus assigner de nom à un humain, on ferais juste new Human(name, age) sans une variable qui designe le nom de l'humain.
        }

        public void Eat()
        {
            System.Console.WriteLine(name + " mange.");
        }
        public void Sleep()
        {
            System.Console.WriteLine(name + " dors.");
        }
        public void NameAge()
        {
            System.Console.WriteLine(name + " a " + age + " ans.");
        }
    }
}