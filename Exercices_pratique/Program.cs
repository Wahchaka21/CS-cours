using System;
using Exercices_pratique;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercice constructors =>
            Constructors_exercices car1 = new Constructors_exercices("Quentyn", "Citroën", "C3", 2009, "noir");
            car1.LaVoiture();

            Supermarché client1 = new Supermarché();
            client1.AjouterAuPanier("Excalibur");
            client1.AjouterAuPanier("Frieren");
            client1.AjouterAuPanier("Manette de PS5");
            client1.SupprimerDuPanier("Manette de PS5");

            client1.AfficherPanier();
            client1.OrTotal();
            //===================================================================================================
        }
    }
}