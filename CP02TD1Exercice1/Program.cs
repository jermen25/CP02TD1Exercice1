using System;

namespace CP02TD1Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {// declaration des données
            float Quantite, PrixUnitaire,MontantTotal, Port, PrixTotal;

            // Saisie de la quantité et du prix 
            Console.Write("Entrez la quantité de bouteilles : ");
            Quantite = float.Parse(Console.ReadLine());
            Console.Write("entrez le prix unitaire : ");
            PrixUnitaire = float.Parse(Console.ReadLine());

            //calcul du montant de la commande
            MontantTotal = Quantite * PrixUnitaire;
            Console.WriteLine("le prix total est de " + MontantTotal + " euros.");

            //calcule du montant des frais de port et du montant total
            if(MontantTotal < 100)
            {
                Port = MontantTotal * 10 / 100;
                
            //Verification du port minimum et attribution du montant minimum
                if(Port<1.5)
                {
                    Port = 1.5f;
                }
             
             //Calcule du Prix total
                PrixTotal = MontantTotal + Port;

             //Affichage des résultats
                Console.WriteLine("le montant des frais de port est de " + Port + "euros.");
                Console.WriteLine("le montant totale est de " + PrixTotal + "euros.");
            }
            Console.WriteLine("Donnez moi 6heures pour couper un arbre, j'en passerais 4 à affûter ma hache!");
        }
    }
}
