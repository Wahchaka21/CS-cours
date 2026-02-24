using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static en gros appartiens à la class, on peut peut pas créer un objet avec ça
            Car car1 = new Car("Citroën");
            Car car2 = new Car("Peugeot");

            //et la on va appeller ce static
            System.Console.WriteLine(Car.numberOfCars); // ça va nous retourner "2" car on a créer deux voitures

            Car.Start();

            //enfaite plus concrètement par exemple les fonction Math sont static =>
            //c'est plus facile d'écrire :
            Math.Round();
            //que d'écrire :
            Math math1 = new Math();
            math1.Round(3.14);
        }
    }
    class Car
    {
        string model;
        //par exemple la on va déclarer un static
        public static int numberOfCars;

        public Car(string model)
        {
            this.model = model;
            numberOfCars++;
        }
        //on peut également créer une méthode
        public static void Start()
        {
            System.Console.WriteLine("La course commence !");
        }
    }
}