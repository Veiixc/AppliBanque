
using System;

class Firstapp
{
    static void AfficherMenu()
    {
        Console.Clear();
        Console.WriteLine("Veuillez sélectionner une option ci - dessous :");
        Console.WriteLine("[I] Voir les informations sur le titulaire du compte");
        Console.WriteLine("[CS] Compte courant - Consulter le solde");
        Console.WriteLine("[CD] Compte courant - Déposer des fonds");
        Console.WriteLine("[CR] Compte courant - Retirer des fonds");
        Console.WriteLine("[ES] Compte épargne - Consulter le solde");
        Console.WriteLine("[ED] Compte épargne - Déposer des fonds");
        Console.WriteLine("[ER] Compte épargne - Retirer des fonds");
        Console.WriteLine("[X] Quitter");
        Console.WriteLine("Votre choix");
    }
    static void Entree()
    {
        ConsoleKeyInfo bouton;
        do
        {
            Console.WriteLine("Entrée pour démarer");
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

    static void Main(string[] args)
    {
        //     string demarage;
        //     do
        //     {
        //         Console.WriteLine("Entrée pour démarer");
        //         demarage = Console.ReadLine();
        //     } while (!string.IsNullOrEmpty(demarage));
        Entree();
        Compte KevinCompte = new Compte(561);
        Client Kevin = new Client("Kevin");
        Kevin.AjouterCompte(KevinCompte);
        KevinCompte.AjouterMontant(50);
        int solde = 0;
        int solde1 = 0;
        bool fin = false;
        while (!fin)
        {
            AfficherMenu();
            string lettre = Console.ReadLine()?.ToUpper();
            switch (lettre)
            {
                case "I":
                    break;
                case "CS":
                    Console.WriteLine("votre solde : ?");
                    Console.WriteLine(solde);
                    Entree2();
                    break;
                case "CD":
                    Console.WriteLine("Quel montant souhaitez-vous déposer ?");
                    string saisie = Console.ReadLine();
                    int dépôt = int.Parse(saisie);
                    solde += dépôt;
                    break;
                case "CR":
                    Console.WriteLine("Quel montant souhaitez-vous retirer ?");
                    string saisie1 = Console.ReadLine();
                    int retrait = int.Parse(saisie1);
                    solde -= retrait;
                    break;
                case "ES":
                    Console.WriteLine("votre solde :");
                    Console.WriteLine(solde1);
                    Entree2();
                    break;
                case "ED":
                    Console.WriteLine("Quel montant souhaitez-vous déposer ?");
                    string saisie2 = Console.ReadLine();
                    int dépôt1 = int.Parse(saisie2);
                    solde1 += dépôt1;
                    break;
                case "ER":
                    Console.WriteLine("Quel montant souhaitez-vous retirer ?");
                    string saisie3 = Console.ReadLine();
                    int retrait1 = int.Parse(saisie3);
                    solde1 -= retrait1;
                    break;
                case "X":
                    fin = true;
                    break;
                default:
                    AfficherMenu();
                    break;

            }

        }

    }
}