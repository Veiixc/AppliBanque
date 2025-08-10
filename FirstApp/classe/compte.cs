class Compte
{
    private int id;
    private double montant;

    public Compte(int id)
    {
        this.id = id;
        this.montant = 0;

    }
    public void AjouterMontant(int montant)
    {
        this.montant += montant;
    }
    public void RetirerMontant(int montant)
    {
        this.montant -= montant;
    }

}