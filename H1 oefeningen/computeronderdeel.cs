using System;

namespace H1_oefeningen
{
    class computeronderdeel
    {
        public int Prijs { get; set; }
        public int ID { get; set; }
        public bool InDoos { get; set; }

        private static Random RNG = new Random();
        public computeronderdeel(int getal)
        {
            Prijs = RNG.Next(getal, 1001);
            ID = RNG.Next(100, 1000);
        }

        public void ToonInfo()
        {
            Console.WriteLine($"PRIJS: {Prijs}\t ID: {ID}\t InDoos: {InDoos}");
        }


    }
}
