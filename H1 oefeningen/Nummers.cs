using System;

namespace H1_oefeningen
{
    class Nummers
    {
        public int Getal1 { get; set; }
        public int Getal2 { get; set; }


        public int Som()
        {

            return Getal1 + Getal2;
        }
        public int Verschil()
        {
            return Getal1 - Getal2;
        }

        public int Product()
        {
            return Getal1 * Getal2;
        }
        public double Quotient()
        {
            if (Getal2 > 0 && Getal1 > 0)
            {

                return Convert.ToDouble(Getal1) / Convert.ToDouble(Getal2);
            }
            Console.WriteLine("Kan niet delen door 0");
            return 0.0;
        }

    }
}
