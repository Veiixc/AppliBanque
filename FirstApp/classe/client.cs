class Client
{
    private string Nom;
    private Compte compte;

    public Client(string Nom)
    {
        this.Nom = Nom;

    }
    public void AjouterCompte(Compte compte)
    {
        this.compte = compte;
    }
}

