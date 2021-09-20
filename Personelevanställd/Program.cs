using System;

namespace Personelevanställd
{
    class Program
    {
        static void Main(string[] args)
        {
            Elev elev1 = new Elev("Karl", "20030607-4156", 2019, "Teknik");
            Console.WriteLine(elev1);
            Anställd anställd1 = new Anställd("Nils", "19750612-5214", 30000);
            Console.WriteLine(anställd1);
        }
    }
}
