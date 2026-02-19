using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercices_pratique
{
    public class Constructors_exercices
    {
        public string propriétaire;
        public string marque;
        public string modèle;
        public int année;
        public string couleur;

        public Constructors_exercices(string propriétaire, string marque, string modèle, int année, string couleur)
        {
            this.propriétaire = propriétaire;
            this.marque = marque;
            this.modèle = modèle;
            this.année = année;
            this.couleur = couleur;
        }

        public void LaVoiture()
        {
            System.Console.WriteLine("La voiture de " + propriétaire + " fait partie de la marque " + marque + " c'est une " + modèle + " de " + année + " avec une très belle couleur " + couleur + ".");
        }
    }
    public class Item
    {
        public string name;
        public int prix;

        public Item(string name, int prix)
        {
            this.name = name;
            this.prix = prix;
        }
    }
    public class Supermarché
    {
        List<Item> panier = new List<Item>();

        List<Item> items = new List<Item>
        {
            new Item("Excalibur", 300),
            new Item("Manette d'Xbox", 60),
            new Item("Manette de PS5", 60),
            new Item("Frieren", 100000000),
        };

        public Supermarché()
        {

        }

        public void AjouterAuPanier(string name)
        {
            Item product = items.Find(p => p.name == name);
            if (product != null)
            {
                panier.Add(product);
                System.Console.WriteLine(product.name + " ajouté au panier");
            }
            else
            {
                System.Console.WriteLine("Produit introuvable");
                return;
            }
        }
        public void AfficherPanier()
        {
            System.Console.WriteLine("=== Panier ===");
            foreach (Item produit in panier)
            {
                System.Console.WriteLine(produit.name + " - " + produit.prix + "€");
            }
        }
        public void SupprimerDuPanier(string name)
        {
            Item removedProduct = panier.Find(p => p.name == name);
            if (removedProduct == null)
            {
                System.Console.WriteLine("Produit introuvable dans le panier");
                return;
            }
            else
            {
                panier.Remove(removedProduct);
                System.Console.WriteLine(removedProduct.name + " retiré du panier");
            }
        }
        public void OrTotal()
        {
            int sum = 0;
            for (int i = 0; i < panier.Count; i++)
            {
                sum += panier[i].prix;
            }
            System.Console.WriteLine($"Vous devez payer : {sum}€");
        }
    }
}