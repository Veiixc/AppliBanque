class Compte
{
    public int id;
    public int Montant { get; protected set; }

    public Compte(int id)
    {
        this.id = id;
        this.Montant = 0;
    }

    public string AjouterMontant(int montant)
    {
        if (montant <= 0) return "Montant invalide.";
        this.Montant += montant;
        return "Montant ajouté.";
    }

    public string RetirerMontant(int montant)
    {
        if (montant <= 0) return "Montant invalide.";
        if (montant > this.Montant) return "Fonds insuffisants.";
        this.Montant -= montant;
        return "Montant retiré.";
    }
}