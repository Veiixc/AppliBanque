using System;
using System.Collections.Generic;

class Firstapp
{
    static void AfficherMenu()
    {
        Console.Clear();
        Console.WriteLine("Veuillez sélectionner une option ci-dessous :");
        Console.WriteLine("[I] Voir les informations sur le titulaire du compte");
        Console.WriteLine("[CS] Compte courant - Consulter le solde");
        Console.WriteLine("[CD] Compte courant - Déposer des fonds");
        Console.WriteLine("[CR] Compte courant - Retirer des fonds");
        Console.WriteLine("[ES] Compte épargne - Consulter le solde");
        Console.WriteLine("[ED] Compte épargne - Déposer des fonds");
        Console.WriteLine("[ER] Compte épargne - Retirer des fonds");
        Console.WriteLine("[X] Quitter");
        Console.Write("Votre choix : ");
    }

    static void Entree()
    {
        ConsoleKeyInfo bouton;
        do
        {
            Console.WriteLine("Entrée pour démarrer");
            bouton = Console.ReadKey();
            Console.WriteLine();
        } while (bouton.Key != ConsoleKey.Enter);
    }

    static void Entree2()
    {
        ConsoleKeyInfo bouton;
        do
        {
            Console.WriteLine("Entrée pour continuer");
            bouton = Console.ReadKey();
            Console.WriteLine();
        } while (bouton.Key != ConsoleKey.Enter);
    }

    static int DemanderMontant(string message)
    {
        Console.Write(message + " ");
        return int.Parse(Console.ReadLine());
    }

    static void Main(string[] args)
    {
        Entree();
        Client Kevin = new Client("Kevin");
        var compteCourant = new CompteCourant(1);
        compteCourant.AjouterMontant(500);
        var compteEpargne = new CompteEpargne(2);
        compteEpargne.AjouterMontant(1028);

        Kevin.AjouterCompte(compteCourant);
        Kevin.AjouterCompte(compteEpargne);

        bool fin = false;
        while (!fin)
        {
            AfficherMenu();
            string lettre = Console.ReadLine()?.ToUpper();
            switch (lettre)
            {
                case "I":
                    Console.WriteLine($"Titulaire : {Kevin.Nom}");
                     Console.WriteLine($"Compte courant  : #{compteCourant.id} - Solde : {compteCourant.Montant} €");
                    Console.WriteLine($"Compte épargne  : #{compteEpargne.id} - Solde : {compteEpargne.Montant} €");
                    Entree2();
                    break;

                case "CS":
                    Console.WriteLine($"Votre solde : {compteCourant.Montant} €");
                    Entree2();
                    break;

                case "CD":
                    var depotC = DemanderMontant("Quel montant souhaitez-vous déposer ?");
                    compteCourant.AjouterMontant(depotC);
                    Console.WriteLine($"Vous avez déposé : {depotC} €.");
                    Entree2();
                    break;

                case "CR":
                    var retraitC = DemanderMontant("Quel montant souhaitez-vous retirer ?");
                    compteCourant.RetirerMontant(retraitC);
                    Console.WriteLine($"Vous avez retiré : {retraitC} €.");
                    Entree2();
                    break;

                case "ES":
                    Console.WriteLine($"Votre solde épargne : {compteEpargne.Montant} €");
                    Entree2();
                    break;

                case "ED":
                    var depotE = DemanderMontant("Quel montant souhaitez-vous déposer ?");
                    compteEpargne.AjouterMontant(depotE);
                    Console.WriteLine($"Vous avez déposé : {depotE} €.");
                    Entree2();
                    break;

                case "ER":
                    var retraitE = DemanderMontant("Quel montant souhaitez-vous retirer ?");
                    compteEpargne.RetirerMontant(retraitE);
                    Console.WriteLine($"Vous avez retiré : {retraitE} €.");
                    Entree2();
                    break;

                case "X":
                    fin = true;
                    break;

                default:
                    Console.WriteLine("Option invalide.");
                    Entree2();
                    break;
            }
        }
    }
}