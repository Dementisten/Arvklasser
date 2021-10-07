class Chef : Anställd
{
     public string Behörighet {get; set;}

    public Chef(string namn, string personnummer, int månadslön, string behörighet) : base(namn, personnummer, månadslön)
    {
        Behörighet = behörighet;
    }

    public override string ToString()
    {
        return base.ToString() + "\n"
        + "Behörighet: " + Behörighet;
    }
}