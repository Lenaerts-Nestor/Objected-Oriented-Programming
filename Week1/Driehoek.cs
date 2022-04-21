using System;

namespace Week1
{
    class Driehoek
    {
        private int basis;

        public int Basis
        {
            get { return basis; }
            set
            {
                if (value >= 1)
                {
                    basis = value;
                }
            }
        }

        private int hoogte;

        public int Hoogte
        {
            get { return hoogte; }
            set
            {
                if (value >= 1)
                {
                    hoogte = value;
                }
            }
        }

        public void ToonOppervlakte()
        {
            //opervlakte berekenen: 
            Console.WriteLine("Driehoek");
            Console.WriteLine($"Hoogte:     {hoogte}");
            Console.WriteLine($"basis:    {basis}\n");
            Console.WriteLine($"Oppervlakte: {(basis * hoogte) / 2}");
        }

    }
}
