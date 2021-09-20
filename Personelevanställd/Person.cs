abstract class Person{

    public string Namn {get; set;}
    public string Personnummer {get; set;}

    public Person(string namn, string personnummer)
    {
        Namn = namn;
        Personnummer = personnummer;
    }


    public override string ToString()
    {
        return 
        "\n" + "Namn: " + Namn +"\n"
        + "Personnummer: " + Personnummer;
    }
}