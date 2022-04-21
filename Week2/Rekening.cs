using System;

namespace Week2

{
    enum RekeningStaat { Geldig, Geblokeerd };
    class Rekening
    {
        //Deel 1
        private int balans;
        public int Balans
        {
            get
            {
                return balans;
            }
        }

        public string NaamKlant { get; set; }
        public string RekeningNummer { get; set; }
        //Deel2 

        public RekeningStaat Staat { get; private set; } = RekeningStaat.Geldig;



        //methoden: 
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




    }
}
