using System;
using System.Collections.Generic;

namespace Personelevanställd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personer = new List<Person>();

            int meny = 0;
            while(meny != 5){
                Console.WriteLine("\n");
                Console.WriteLine("1. Lägg till ny anställd.");
                Console.WriteLine("2. Lägg till ny elev.");
                Console.WriteLine("3. Lägg till ny chef.");
                Console.WriteLine("4. Lista upp alla personer.");
                Console.WriteLine("5. Stäng programmet.");
                meny = int.Parse(Console.ReadLine());

                if (meny == 1)
                {
                    Console.Write("Namn: ");
                    string NAMN = Console.ReadLine();
                    Console.Write("Personnummer: ");
                    string PNR = Console.ReadLine();
                    Console.Write("Månadslön: ");
                    int LÖN = int.Parse(Console.ReadLine());
                    personer.Add(new Anställd(NAMN, PNR, LÖN));
                }
                if (meny == 2)
                {
                    Console.Write("Namn: ");
                    string NAMN = Console.ReadLine();
                    Console.Write("Personnummer: ");
                    string PNR = Console.ReadLine();
                    Console.Write("Antagningsår: ");
                    int YEAR = int.Parse(Console.ReadLine());
                    Console.Write("Utbildningsprogram: ");
                    string PROG = Console.ReadLine();
                    personer.Add(new Elev(NAMN, PNR, YEAR, PROG));
                }
                if (meny == 3)
                {
                    Console.Write("Namn: ");
                    string NAMN = Console.ReadLine();
                    Console.Write("Personnummer: ");
                    string PNR = Console.ReadLine();
                    Console.Write("Månadslön: ");
                    int LÖN = int.Parse(Console.ReadLine());
                    Console.Write("Behörighet: ");
                    string RANK = Console.ReadLine();
                    personer.Add(new Chef(NAMN, PNR, LÖN, RANK));
                }
                if (meny == 4)
                {
                    foreach (Person a in personer)
                    {
                        Console.WriteLine("===================");
                        Console.WriteLine(a);
                    }
                }

            }
        }
    }
}

