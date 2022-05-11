using System;
using System.Collections.Generic;

namespace Arrays_en_Klassen
{
    internal class Program
    {
        static void OEFENING1()
        {
            //OEFENING 1

            Console.WriteLine("Hello World!");
            /*
            Maak een array die tot 20 prijzen (double) kan bewaren. 
            Vraag aan de gebruiker om 20 prijzen in te voeren en bewaar deze in de array. 
            Doorloop vervolgens m.b.v. een foreach-lus de volledige array en toon enkel de elementen op het scherm wiens prijs hoger of gelijk is aan €5.00. 
            Toon op het einde van het programma het gemiddelde van alle prijzen (dus inclusief de lagere prijzen).*/

            double[] vs = new double[20];
            Random r = new Random();
            for (int i = 0; i < vs.Length; i++)
            {
                vs[i] = r.Next(1, 20);
                Console.WriteLine(vs[i]);
            }

            Console.WriteLine("\n");
            double gemiddelde = 0;
            foreach (var item in vs)
            {
                gemiddelde += item;
                if (item >= 5.00)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(item);
                    Console.ResetColor();

                }

            }
            Console.WriteLine(gemiddelde / vs.Length);
        }
        static void OEFENING2()
        {
            //COMPUTER WINKEL OEFENING2

            List<computeronderdeel> Filteren = new List<computeronderdeel>();

            //objecten toevoegen aan de list Filteren
            for (int i = 0; i < 100; i++)
            {
                Filteren.Add(new computeronderdeel());
            }
            //FILTEREN:
            //PRIJS
            Console.WriteLine("\nOP BASIS VAN Prijs");
            foreach (var item in Filteren)
            {
                if (item.Prijs >= 400)
                {
                    item.ToonInfo();
                }


            }
            //INDOOS
            Console.WriteLine("\nOP BASIS VAN InDoos");
            Console.ReadKey();
            foreach (var item in Filteren)
            {
                if (item.InDoos == true)
                {
                    item.ToonInfo();
                }

            }
            //ID + PRIJS
            Console.WriteLine("\nOP BASIS VAN ID en Prijs");
            Console.ReadKey();
            foreach (var item in Filteren)
            {
                if (item.ID <= 200 && item.Prijs <= 200)
                {
                    item.ToonInfo();
                }

            }



            //MANAGEN; Deze gedeelte heb ik nog niet getest, maar het zou juist moeten zijn.
            Console.WriteLine("wat moet er nu gebueren?");
            Console.WriteLine("1: alle objecten in een doos verwijderen");
            Console.WriteLine("2: alle objecten met een prijs kleiner dan 100 verwijderen");
            int keuze = Convert.ToInt32(Console.ReadLine());
            int P = 0;
            if (keuze == 1)
            {
                foreach (var item in Filteren)
                {

                    if (item.InDoos == true)
                    {
                        Filteren.RemoveAt(P);
                    }
                    P++;
                }
            }
            else
            {
                foreach (var item in Filteren)
                {

                    if (item.Prijs < 200)
                    {
                        Filteren.RemoveAt(P);
                    }
                    P++;
                }
            }


        }

        static void Main(string[] args)
        {





        }
    }
}
