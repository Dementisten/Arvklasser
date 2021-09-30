using System;
using System.Collections.Generic;

namespace Personelevanställd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Elev> elever = new List<Elev>();
            List<Anställd> anställda = new List<Anställd>();

            int meny = 0;
            while(meny != 4){
                Console.WriteLine("\n");
                Console.WriteLine("1. Lägg till ny anställd.");
                Console.WriteLine("2. Lägg till ny elev.");
                Console.WriteLine("3. Lista upp alla personer.");
                Console.WriteLine("4. Stäng programmet.");
                meny = int.Parse(Console.ReadLine());

                if (meny == 1)
                {
                    Console.Write("Namn: ");
                    string NAMN = Console.ReadLine();
                    Console.Write("Personnummer: ");
                    string PNR = Console.ReadLine();
                    Console.Write("Månadslön: ");
                    int LÖN = int.Parse(Console.ReadLine());
                    anställda.Add(new Anställd(NAMN, PNR, LÖN));
                }
                if (meny == 2)
                {
                    Console.Write("Namn: ");
                    string NAMN = Console.ReadLine();
                    Console.Write("Personnummer: ");
                    string PNR = Console.ReadLine();
                    Console.Write("Antagningsår: ");
                    int YEAR = int.Parse(Console.ReadLine());
                    Console.Write("Utbildningsprogram");
                    string PROG = Console.ReadLine();
                    elever.Add(new Elev(NAMN, PNR, YEAR, PROG));
                }
                if (meny == 3)
                {
                    foreach (Elev a in elever)
                    {
                        Console.WriteLine("===================");
                        Console.WriteLine(a);
                    }
                    foreach (Anställd a in anställda)
                    {
                        Console.WriteLine("===================");
                        Console.WriteLine(a);
                    }
                }

            }
        }
    }
}

