class Anställd : Person
{
    public int Månadslön {get; set;}
    public Anställd(string namn, string personnummer, int månadslön) : base(namn, personnummer)
    {
        Månadslön = månadslön;
    }


    public override string ToString()
    {
        return base.ToString() + "\n"
        + "Månadslön: " + Månadslön;
    }
}