using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //un object est l'instance d'une classe, une classe peut être utilisé comme schéma pour créer un object.

            //Une fois notre classe faite (donc la classe Human) on peut créer un object basé sur la class Human, par exemple un object human nommé human1 =>

            Human human1 = new Human();

            //maintenant on peut avoir acces au méthodes stockée dans la class Human via human1 =>
            human1.name = "Guts";
            human1.age = 23;

            human1.Eat();
            human1.Sleep();
            human1.NameAge();

            //on peut créer autant d'humain qu'on veut grâce à ça, par exemple créont un autre exemple =>

            Human human2 = new Human();

            human2.name = "Frieren";
            human2.age = 1227;

            human2.Eat();
            human2.Sleep();
            human2.NameAge();

        }
    }
    //en dehors de notre classe principale (ici Program) on va créer une classe =>
    class Human()
    {
        //fields (ce que les objects ont)=>
        public string name;
        public int age;

        //méthodes (ce que les object peuvent faire) =>
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