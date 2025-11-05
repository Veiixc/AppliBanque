class Client
{
    public string Nom;
    private List<Compte> comptes = new List<Compte>();

    public Client(string nom)
    {
        this.Nom = nom;
    }

    public void AjouterCompte(Compte compte)
    {
        comptes.Add(compte);
    }
}