using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Program__main_
{
    enum RekeningStaat { Geldig, Geblokeerd };
    class Bankmanager_2
    {

        //iedereen krijgt 2k bij begin       
        private int balans = 2000;
        public int Balans
        {
            get
            {
                return balans;
            }
        }

        public string NaamKlant { get; set; }
        public string RekeningNummer { get; set; }
       
        //enum methode
        public RekeningStaat Staat { get; private set; } = RekeningStaat.Geldig;
        //methoden
        public int HaalGeldAf(int bedrag)
        {
            if (Staat == RekeningStaat.Geldig)
            {
                if (bedrag > balans)
                {
                    int ovegebleefBalans = balans;
                    balans = 0;
                    Console.WriteLine("Rekening leeg nu");
                    VeranderStaat();
                    return ovegebleefBalans;
                }
                else
                {
                    balans -= bedrag;
                    return bedrag;
                }
            }
            else
            {
                Console.WriteLine("gaat niet, rekening geblokeerd");
                return 0;
            }

        }

        public void StortGeld(int bedrag)
        {

            if (Staat == RekeningStaat.Geldig)
            {
                balans += bedrag;
            }
            else
            {
                Console.WriteLine("Gaat niet. Rekening geblokkeerd.");
            }
        }

        public RekeningStaat VeranderStaat()
        {
            if (Staat == RekeningStaat.Geldig)
            {
                Staat = RekeningStaat.Geblokeerd;
                return Staat;
            }
            else
            {
                Staat = RekeningStaat.Geldig;
                return Staat;
            }
        }
        public void ToonInfo()
        {
            Console.WriteLine($"Naam:\t {NaamKlant}");
            Console.WriteLine($"RekeningsNr:\t {RekeningNummer}");
            Console.WriteLine($"Balans:\t {balans}");

        }


        //Bankmanager 2 methode:

        public void SimuleerOverdtacht(Bankmanager_2 eersteRekening, Bankmanager_2 tweedeRekening)
        {
            Console.Clear();
            Random randombedrag = new Random();
            Random gekozenRekening = new Random();
            for (int i = 0; i < 5; i++)
            {
               
                //PERSOON WORDT RANDOMLY GEKOZEN.
                int gekozenPersoon = gekozenRekening.Next(0,2);
                Console.WriteLine($"random nummer voor rekening is: {gekozenPersoon}");
                //ik heb extra INFORMATIE DERBIJ GEDAAN VOOR VISUELE DUIDELIJKHEID.
                if (gekozenPersoon == 0)
                {
                    int amount = randombedrag.Next(1, 20);
                    eersteRekening.StortGeld(tweedeRekening.HaalGeldAf(amount));
                    Console.WriteLine($"{eersteRekening.NaamKlant} heeft {amount} gekregen van {tweedeRekening.NaamKlant} en er is {amount} eruit gehaald van zijn rekenening.");
                    Console.WriteLine($"het balans van {eersteRekening.NaamKlant} is nu {eersteRekening.balans}");
                    Console.WriteLine($"het balans van {tweedeRekening.NaamKlant} is nu {tweedeRekening.balans}");
                }
                else
                {
                    int amount = randombedrag.Next(20, 36);
                    tweedeRekening.StortGeld(eersteRekening.HaalGeldAf(amount));
                    Console.WriteLine($"{tweedeRekening.NaamKlant} heeft {amount} gekregen van {eersteRekening.NaamKlant} en er is {amount} eruit gehaald van zijn rekenening.");
                    Console.WriteLine($"het balans van {eersteRekening.NaamKlant} is nu {eersteRekening.balans}");
                    Console.WriteLine($"het balans van {tweedeRekening.NaamKlant} is nu {tweedeRekening.balans}");
                }
                Console.ReadKey();
                Console.Clear();

            }
            Console.WriteLine("random transacties zijn voorbij");
        }

        public Bankmanager_2 CreerTienerRekening( string naam)
        {
            Bankmanager_2 Tiener = new Bankmanager_2();
            Tiener.NaamKlant = naam;
            Tiener.balans = 50;
            return Tiener;
            
        }

    }
}
