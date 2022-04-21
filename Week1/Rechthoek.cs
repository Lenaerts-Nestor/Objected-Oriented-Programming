using System;

namespace Week1
{
    class Rechthoek
    {
        private int lengte;

        public int Lengte
        {
            get { return lengte; }
            set
            {
                if (value >= 1)
                {
                    lengte = value;
                }
            }
        }

        private int breedte;

        public int Breedte
        {
            get { return breedte; }
            set
            {
                if (value >= 1)
                {
                    breedte = value;
                }
            }
        }

        public void ToonOppervlakte()
        {
            //opervlakte berekenen: 
            Console.WriteLine("Rechthoek");
            Console.WriteLine($"Lengte:     {lengte}");
            Console.WriteLine($"Breedte:    {breedte}\n");
            Console.WriteLine($"Oppervlakte: {breedte * lengte}");

        }

    }
}
