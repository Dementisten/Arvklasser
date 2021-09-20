class Elev : Person
{

    public int Antagningsår {get; set;}
    public string Utbildningsprogram {get; set;}

    public Elev(string namn, string personnummer, int år, string prog) : base(namn, personnummer)
    {
        Antagningsår = år;
        Utbildningsprogram = prog;
    }

    public override string ToString()
    {
        return base.ToString() + "\n"
        + "Antagningsår: " + Antagningsår + "\n"
        + "Program: " + Utbildningsprogram;
    }
}